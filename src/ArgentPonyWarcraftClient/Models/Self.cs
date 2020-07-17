using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A self-reference.
    /// </summary>
    public class Self
    {
        /// <summary>
        /// Gets a URI for retrieving the data for this object.
        /// </summary>
        [JsonPropertyName("href")]
        public Uri Href { get; private set; }
    }
}
