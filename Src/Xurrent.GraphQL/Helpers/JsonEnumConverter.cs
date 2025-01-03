using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Xurrent.GraphQL.Helpers
{
    /// <summary>
    /// An enumerator tolerant <see cref="JsonConverter"/>.
    /// </summary>
    public class JsonEnumConverter : JsonConverter
    {
        private static readonly ConcurrentDictionary<Type, Dictionary<string, object>> fromList = new();
        private static readonly ConcurrentDictionary<Type, Dictionary<object, string>> toList = new();


        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            return (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(objectType) ?? throw new ArgumentNullException(nameof(objectType)) : objectType).IsEnum;
        }

        /// <inheritdoc />
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            bool isNullable = objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>);
            Type enumType = isNullable ? Nullable.GetUnderlyingType(objectType) ?? throw new JsonSerializationException($"Unable to parse '{reader.Value}', unknown type.") : objectType;
            AddMapping(enumType);

            if (reader.TokenType == JsonToken.String && fromList != null)
            {
                if (reader.Value != null && reader.Value.ToString() is string value)
                {
                    if (fromList[enumType].TryGetValue(value, out object? retval) && retval != null)
                        return retval;
                }
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                int enumValue = Convert.ToInt32(reader.Value, CultureInfo.InvariantCulture);
                int[] values = (int[])Enum.GetValues(enumType);

                if (values.Contains(enumValue))
                    return Enum.Parse(enumType, enumValue.ToString(CultureInfo.InvariantCulture));
            }

            return !isNullable ? Activator.CreateInstance(enumType) : null;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value != null && toList != null)
            {
                Type enumType = value.GetType();
                AddMapping(enumType);
                writer.WriteValue(toList.TryGetValue(enumType, out Dictionary<object, string>? list) && list.TryGetValue(value, out string? retval) ? retval : null);
            }
        }

        private static void AddMapping(Type enumType)
        {
            if (fromList.ContainsKey(enumType))
                return;

            Dictionary<string, object> fromMap = new(StringComparer.InvariantCultureIgnoreCase);
            Dictionary<object, string> toMap = new();

            FieldInfo[] fieldsInfo = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo field in fieldsInfo)
            {
                string name = field.Name;
                object enumValue = Enum.Parse(enumType, name);

                EnumMemberAttribute? enumMemberAttrbiute = field.GetCustomAttribute<EnumMemberAttribute>();
                if (enumMemberAttrbiute != null && enumMemberAttrbiute.Value != null)
                {
                    fromMap[enumMemberAttrbiute.Value] = enumValue;
                    toMap[enumValue] = enumMemberAttrbiute.Value;
                }
                else
                {
                    toMap[enumValue] = name;
                }
                fromMap[name] = enumValue;
            }
            fromList[enumType] = fromMap;
            toList[enumType] = toMap;
        }
    }
}
