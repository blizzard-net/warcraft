using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP rewards for a PvP season.
    /// </summary>
    public class PvpRewardsIndex
    {
        /// <summary>
        /// Gets links for the PvP rewards.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonProperty("season")]
        public PvpSeasonReference Season { get; set; }

        /// <summary>
        /// Gets the rewards for the PvP season.
        /// </summary>
        [JsonProperty("rewards")]
        public PvpSeasonReward[] Rewards { get; set; }
    }
}
