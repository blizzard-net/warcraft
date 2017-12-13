using System;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An error while communicating with the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClientException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClientException" /> class.
        /// </summary>
        public WarcraftClientException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClientException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public WarcraftClientException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and
        /// a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a <c>null</c> reference
        /// (<c>Nothing</c> in Visual Basic) if no inner exception is specified.
        /// </param>
        public WarcraftClientException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
