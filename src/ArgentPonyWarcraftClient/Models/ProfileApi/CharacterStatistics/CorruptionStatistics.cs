using Newtonsoft.Json;

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
        [JsonProperty("corruption")]
        public long Corruption { get; set; }

        /// <summary>
        /// Gets the corruption resistance.
        /// </summary>
        [JsonProperty("corruption_resistance")]
        public long CorruptionResistance { get; set; }

        /// <summary>
        /// Gets the effective corruption.
        /// </summary>
        [JsonProperty("effective_corruption")]
        public long EffectiveCorruption { get; set; }
    }
}
