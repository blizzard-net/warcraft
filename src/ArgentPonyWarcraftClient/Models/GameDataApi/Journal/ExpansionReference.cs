using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to game expansion.
    /// </summary>
    public class ExpansionReference
    {
        /// <summary>
        /// Gets the key for the expansion.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
