using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Represent errors that occurs on Xurrent filters.
    /// </summary>
    public sealed class XurrentFilterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentFilterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XurrentFilterException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentFilterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public XurrentFilterException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
