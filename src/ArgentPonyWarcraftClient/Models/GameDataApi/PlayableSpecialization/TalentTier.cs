using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent tier.
    /// </summary>
    public class TalentTier
    {
        /// <summary>
        /// Gets the player level at which the talent tier unlocks.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets references to the talents for this tier.
        /// </summary>
        [JsonPropertyName("talents")]
        public TalentTierElement[] Talents { get; set; }

        /// <summary>
        /// Gets the index of the talent tier.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; set; }
    }
}
