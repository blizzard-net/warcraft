using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent tier.
    /// </summary>
    public record TalentTier
    {
        /// <summary>
        /// Gets the player level at which the talent tier unlocks.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets references to the talents for this tier.
        /// </summary>
        [JsonPropertyName("talents")]
        public TalentTierElement[] Talents { get; }

        /// <summary>
        /// Gets the index of the talent tier.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentTier"/> class.
        /// </summary>
        /// <param name="level">The player level at which the talent tier unlocks.</param>
        /// <param name="talents">References to the talents for this tier.</param>
        /// <param name="tierIndex">The index of the talent tier.</param>
        [JsonConstructor]
        public TalentTier(int level, TalentTierElement[] talents, int tierIndex)
        {
            Level = level;
            Talents = talents;
            TierIndex = tierIndex;
        }
    }
}
