using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant renown reward.
    /// </summary>
    public record RenownReward
    {
        /// <summary>
        /// Gets the renown level that the reward is earned at.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets the reward reference.
        /// </summary>
        [JsonPropertyName("reward")]
        public CovenantRewardReference Reward { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenownReward"/> class.
        /// </summary>
        /// <param name="level">The renown level that the reward is earned at.</param>
        /// <param name="reward">The reward reference.</param>
        [JsonConstructor]
        public RenownReward(int level, CovenantRewardReference reward)
        {
            Level = level;
            Reward = reward;
        }
    }
}
