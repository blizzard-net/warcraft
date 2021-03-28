using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Corruption statistics.
    /// </summary>
    public record CorruptionStatistics
    {
        /// <summary>
        /// Gets the corruption level.
        /// </summary>
        [JsonPropertyName("corruption")]
        public float Corruption { get; }

        /// <summary>
        /// Gets the corruption resistance.
        /// </summary>
        [JsonPropertyName("corruption_resistance")]
        public float CorruptionResistance { get; }

        /// <summary>
        /// Gets the effective corruption.
        /// </summary>
        [JsonPropertyName("effective_corruption")]
        public float EffectiveCorruption { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorruptionStatistics"/> class.
        /// </summary>
        /// <param name="corruption">The corruption level.</param>
        /// <param name="corruptionResistance">The corruption resistance.</param>
        /// <param name="effectiveCorruption">The effective corruption.</param>
        [JsonConstructor]
        public CorruptionStatistics(float corruption, float corruptionResistance, float effectiveCorruption)
        {
            Corruption = corruption;
            CorruptionResistance = corruptionResistance;
            EffectiveCorruption = effectiveCorruption;
        }
    }
}
