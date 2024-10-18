using System.Collections.Generic;
using System.Collections.Immutable;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The Xurrent object item property change collection.
    /// </summary>
    public class PropertyChangeSet
    {
        private readonly HashSet<string> fields = new();

        /// <summary>
        /// Stores the name in the field collection.
        /// </summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        /// <returns>The property value.</returns>
        internal protected T Set<T>(string name, T value)
        {
            fields.Add(name);
            return value;
        }

        /// <summary>
        /// Get all changed field names.
        /// </summary>
        /// <returns>A list of changed field names.</returns>
        public ImmutableHashSet<string> GetFields()
        {
            return fields.ToImmutableHashSet();
        }
    }
}
