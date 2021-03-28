using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </summary>
    public record PvpLeaderboard
    {
        /// <summary>
        /// Gets links for the PvP Leaderboard.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonPropertyName("season")]
        public PvpSeasonReference Season { get; }

        /// <summary>
        /// Gets the name of the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// A PvP bracket.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; }

        /// <summary>
        /// Gets the entries in the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("entries")]
        public PvpLeaderboardEntry[] Entries { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpLeaderboard"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP Leaderboard.</param>
        /// <param name="season">A reference to the PvP season.</param>
        /// <param name="name">The name of the PvP leaderboard.</param>
        /// <param name="bracket">The name of the PvP leaderboard.</param>
        /// <param name="entries">The entries in the PvP leaderboard.</param>
        [JsonConstructor]
        public PvpLeaderboard(Links links, PvpSeasonReference season, string name, Bracket bracket, PvpLeaderboardEntry[] entries)
        {
            Links = links;
            Season = season;
            Name = name;
            Bracket = bracket;
            Entries = entries;
        }
    }
}
