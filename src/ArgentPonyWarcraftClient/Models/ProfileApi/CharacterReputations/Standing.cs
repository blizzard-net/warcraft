using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's standing with a reputation faction.
    /// </summary>
    public class Standing
    {
        /// <summary>
        /// Gets the raw number.
        /// </summary>
        [JsonPropertyName("raw")]
        public int Raw { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonPropertyName("max")]
        public int Max { get; set; }

        /// <summary>
        /// Gets the reputation tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Gets the name of the standing.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
