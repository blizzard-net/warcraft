using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP leaderboards for a PvP season.
    /// </summary>
    public record PvpLeaderboardsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP leaderboards.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonPropertyName("season")]
        public PvpSeasonReference Season { get; }

        /// <summary>
        /// Gets references to the PvP leaderboards.
        /// </summary>
        [JsonPropertyName("leaderboards")]
        public PvpLeaderboardReference[] Leaderboards { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpLeaderboardsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of PvP leaderboards.</param>
        /// <param name="season">A reference to the PvP season.</param>
        /// <param name="leaderboards">References to the PvP leaderboards.</param>
        [JsonConstructor]
        public PvpLeaderboardsIndex(Links links, PvpSeasonReference season, PvpLeaderboardReference[] leaderboards)
        {
            Links = links;
            Season = season;
            Leaderboards = leaderboards;
        }
    }
}
