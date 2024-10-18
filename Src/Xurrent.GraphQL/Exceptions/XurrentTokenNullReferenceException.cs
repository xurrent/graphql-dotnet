using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Represent errors that occurs on Xurrent token usage.
    /// </summary>
    public sealed class XurrentTokenNullReferenceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentTokenNullReferenceException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XurrentTokenNullReferenceException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentTokenNullReferenceException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public XurrentTokenNullReferenceException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
