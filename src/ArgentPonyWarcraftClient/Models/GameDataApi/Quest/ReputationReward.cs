using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation reward for completing a quest.
    /// </summary>
    public record ReputationReward
    {
        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonPropertyName("reward")]
        public ReputationFactionReference Reward { get; }

        /// <summary>
        /// Gets the amount of reputation gained with the reputation faction.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationReward"/> class.
        /// </summary>
        /// <param name="reward">A reference to the reputation faction.</param>
        /// <param name="value">The amount of reputation gained with the reputation faction.</param>
        [JsonConstructor]
        public ReputationReward(ReputationFactionReference reward, int value)
        {
            Reward = reward;
            Value = value;
        }
    }
}
