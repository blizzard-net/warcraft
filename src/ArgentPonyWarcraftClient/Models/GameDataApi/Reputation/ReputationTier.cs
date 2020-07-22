using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation tier.
    /// </summary>
    public class ReputationTier
    {
        /// <summary>
        /// Gets the name of the reputation tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum value of the reputation tier.
        /// </summary>
        [JsonPropertyName("min_value")]
        public int MinValue { get; set; }

        /// <summary>
        /// Gets the maximum value of the reputation tier.
        /// </summary>
        [JsonPropertyName("max_value")]
        public int MaxValue { get; set; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
