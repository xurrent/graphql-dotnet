using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Instruct the <see cref="XurrentClient"/> to use this as a default property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class XurrentFieldAttribute : Attribute
    {
        /// <summary>
        /// Indicates if this is a default property.
        /// </summary>
        public bool IsDefaultQueryProperty { get; set; }

        /// <summary>
        /// Indicates if this field is required in a mutation.
        /// </summary>
        public bool IsRequiredForMutation { get; set; }

        /// <summary>
        /// Create a new instance of the <see cref="XurrentFieldAttribute"/> class.
        /// </summary>
        public XurrentFieldAttribute()
        {
        }
    }
}
