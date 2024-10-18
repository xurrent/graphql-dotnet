using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Represent errors that occurs in the query builder.
    /// </summary>
    public sealed class XurrentInvalidFieldNameException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentInvalidFieldNameException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XurrentInvalidFieldNameException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentInvalidFieldNameException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public XurrentInvalidFieldNameException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
