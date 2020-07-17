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
        public long Corruption { get; set; }

        /// <summary>
        /// Gets the corruption resistance.
        /// </summary>
        [JsonPropertyName("corruption_resistance")]
        public long CorruptionResistance { get; set; }

        /// <summary>
        /// Gets the effective corruption.
        /// </summary>
        [JsonPropertyName("effective_corruption")]
        public long EffectiveCorruption { get; set; }
    }
}
