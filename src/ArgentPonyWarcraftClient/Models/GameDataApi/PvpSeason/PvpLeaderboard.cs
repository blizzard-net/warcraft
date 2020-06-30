using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </summary>
    public class PvpLeaderboard
    {
        /// <summary>
        /// Gets links for the PvP Leaderboard.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonProperty("season")]
        public PvpSeasonReference Season { get; set; }

        /// <summary>
        /// Gets the name of the PvP leaderboard.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A PvP bracket.
        /// </summary>
        [JsonProperty("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets the entries in the PvP leaderboard.
        /// </summary>
        [JsonProperty("entries")]
        public PvpLeaderboardEntry[] Entries { get; set; }
    }
}
