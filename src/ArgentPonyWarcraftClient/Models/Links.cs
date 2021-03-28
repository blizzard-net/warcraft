using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A collection of links.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Gets a self-reference.
        /// </summary>
        [JsonPropertyName("self")]
        public Self Self { get; set; }
    }
}
