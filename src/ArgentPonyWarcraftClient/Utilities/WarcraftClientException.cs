using System;
using System.Net;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An error while communicating with the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClientException : Exception
    {
        /// <summary>
        /// Gets the reason phrase which typically is sent by servers together with the status code.
        /// </summary>
        public string ResponseReasonPhrase { get; }

        /// <summary>
        /// Gets the URI the request was sent to.
        /// </summary>
        /// <remarks>
        /// The API key is masked in the URI.
        /// </remarks>
        public string RequestUri { get; }

        /// <summary>
        /// Gets the response content.
        /// </summary>
        public string ResponseContent { get; }

        /// <summary>
        /// Gets the status code of the HTTP response.
        /// </summary>
        public HttpStatusCode ResponseStatusCode { get; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and
        /// a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a <c>null</c> reference
        /// (<c>Nothing</c> in Visual Basic) if no inner exception is specified.
        /// </param>
        /// <param name="requestUri">The URI the request was sent to.</param>
        /// <param name="responseStatusCode">The status code of the HTTP response.</param>
        /// <param name="responseReasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code.
        /// </param>
        /// <param name="responseContent">The response content.</param>
        public WarcraftClientException(
            string message,
            Exception innerException,
            string requestUri,
            HttpStatusCode responseStatusCode,
            string responseReasonPhrase,
            string responseContent)
            : base(message, innerException)
        {
            RequestUri = requestUri;
            ResponseStatusCode = responseStatusCode;
            ResponseReasonPhrase = responseReasonPhrase;
            ResponseContent = responseContent;
        }
    }
}
