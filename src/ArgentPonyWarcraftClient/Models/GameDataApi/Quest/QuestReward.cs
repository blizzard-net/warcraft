using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest reward.
    /// </summary>
    public record QuestReward
    {
        /// <summary>
        /// Gets the number of experience points granted for completing the quest.
        /// </summary>
        [JsonPropertyName("experience")]
        public int Experience { get; }

        /// <summary>
        /// Gets the reputation gains for completing the quest.
        /// </summary>
        [JsonPropertyName("reputations")]
        public ReputationReward[] Reputations { get; }

        /// <summary>
        /// Get the monetary reward for completing the quest.
        /// </summary>
        [JsonPropertyName("money")]
        public Money Money { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestReward"/> class.
        /// </summary>
        /// <param name="experience">The number of experience points granted for completing the quest.</param>
        /// <param name="reputations">The reputation gains for completing the quest.</param>
        /// <param name="money">The reputation gains for completing the quest.</param>
        [JsonConstructor]
        public QuestReward(int experience, ReputationReward[] reputations, Money money)
        {
            Experience = experience;
            Reputations = reputations;
            Money = money;
        }
    }
}
