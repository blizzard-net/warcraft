using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Corruption statistics.
    /// </summary>
    public class CorruptionStatistics
    {
        /// <summary>
        /// Gets the corruption level.
        /// </summary>
        [JsonPropertyName("corruption")]
        public float Corruption { get; set; }

        /// <summary>
        /// Gets the corruption resistance.
        /// </summary>
        [JsonPropertyName("corruption_resistance")]
        public float CorruptionResistance { get; set; }

        /// <summary>
        /// Gets the effective corruption.
        /// </summary>
        [JsonPropertyName("effective_corruption")]
        public float EffectiveCorruption { get; set; }
    }
}
