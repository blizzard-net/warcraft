using Newtonsoft.Json;

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
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets references to the talents for this tier.
        /// </summary>
        [JsonProperty("talents")]
        public TalentTierElement[] Talents { get; set; }

        /// <summary>
        /// Gets the index of the talent tier.
        /// </summary>
        [JsonProperty("tier_index")]
        public long TierIndex { get; set; }
    }
}
