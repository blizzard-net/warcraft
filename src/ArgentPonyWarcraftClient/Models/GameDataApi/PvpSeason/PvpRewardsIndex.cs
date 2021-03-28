using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP rewards for a PvP season.
    /// </summary>
    public record PvpRewardsIndex
    {
        /// <summary>
        /// Gets links for the PvP rewards.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonPropertyName("season")]
        public PvpSeasonReference Season { get; }

        /// <summary>
        /// Gets the rewards for the PvP season.
        /// </summary>
        [JsonPropertyName("rewards")]
        public PvpSeasonReward[] Rewards { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpRewardsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP rewards.</param>
        /// <param name="season">A reference to the PvP season.</param>
        /// <param name="rewards">The rewards for the PvP season.</param>
        [JsonConstructor]
        public PvpRewardsIndex(Links links, PvpSeasonReference season, PvpSeasonReward[] rewards)
        {
            Links = links;
            Season = season;
            Rewards = rewards;
        }
    }
}
