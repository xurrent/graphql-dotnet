using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Instruct the <see cref="XurrentClient"/> to use ignore the <see cref="Node.ID"/> property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class XurrentEntityAttribute : Attribute
    {
        /// <summary>
        /// Returns true when the query should exclude the default identifier property.
        /// </summary>
        public bool IgnoreIdentifier { get; set; }

        /// <summary>
        /// Create a new instance of the <see cref="XurrentEntityAttribute"/> class.
        /// </summary>
        public XurrentEntityAttribute()
        {
        }

        /// <summary>
        /// Create a new instance of the <see cref="XurrentEntityAttribute"/> class.
        /// <param name="ignoreIdentifier">True when the query should ignore the default identifier property; otherwise false.</param>
        /// </summary>
        public XurrentEntityAttribute(bool ignoreIdentifier)
        {
            IgnoreIdentifier = ignoreIdentifier;
        }
    }
}
