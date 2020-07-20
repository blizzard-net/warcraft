using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation reward for completing a quest.
    /// </summary>
    public class ReputationReward
    {
        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonPropertyName("reward")]
        public ReputationFactionReference Reward { get; set; }

        /// <summary>
        /// Gets the amount of reputation gained with the reputation faction.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
