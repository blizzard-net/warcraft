using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP leaderboards for a PvP season.
    /// </summary>
    public class PvpLeaderboardsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP leaderboards.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the PvP season.
        /// </summary>
        [JsonProperty("season")]
        public PvpSeasonReference Season { get; set; }

        /// <summary>
        /// Gets references to the PvP leaderboards.
        /// </summary>
        [JsonProperty("leaderboards")]
        public PvpLeaderboardReference[] Leaderboards { get; set; }
    }
}
