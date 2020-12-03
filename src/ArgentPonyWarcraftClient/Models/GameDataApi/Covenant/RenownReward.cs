using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A covenant renown reward.
    /// </summary>
    public class RenownReward
    {
        /// <summary>
        /// Gets the renown level that the reward is earned at.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets the reward reference.
        /// </summary>
        [JsonPropertyName("reward")]
        public RenownRewardReference Reward { get; set; }
    }
}
