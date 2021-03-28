using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A self-reference.
    /// </summary>
    public record Self
    {
        /// <summary>
        /// Gets a URI for retrieving the data for this object.
        /// </summary>
        [JsonPropertyName("href")]
        public Uri Href { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Self"/> class.
        /// </summary>
        /// <param name="href">A URI for retrieving the data for this object.</param>
        [JsonConstructor]
        public Self(Uri href)
        {
            Href = href;
        }
    }
}
