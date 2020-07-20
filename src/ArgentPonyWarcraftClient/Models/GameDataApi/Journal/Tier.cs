using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tier of content.
    /// </summary>
    public class Tier
    {
        /// <summary>
        /// Gets the key for the tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the tier.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
