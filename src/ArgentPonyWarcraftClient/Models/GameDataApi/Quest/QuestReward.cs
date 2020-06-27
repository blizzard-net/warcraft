using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest reward.
    /// </summary>
    public class QuestReward
    {
        /// <summary>
        /// Gets the number of experience points granted for completing the quest.
        /// </summary>
        [JsonProperty("experience")]
        public long Experience { get; set; }

        /// <summary>
        /// Gets the reputation gains for completing the quest.
        /// </summary>
        [JsonProperty("reputations")]
        public ReputationReward[] Reputations { get; set; }

        /// <summary>
        /// Get the monetary reward for completing the quest.
        /// </summary>
        [JsonProperty("money")]
        public Money Money { get; set; }
    }
}
