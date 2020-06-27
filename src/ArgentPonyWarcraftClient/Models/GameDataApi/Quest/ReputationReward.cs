using Newtonsoft.Json;

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
        [JsonProperty("reward")]
        public ReputationFactionReference Reward { get; set; }

        /// <summary>
        /// Gets the amount of reputation gained with the reputation faction.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
