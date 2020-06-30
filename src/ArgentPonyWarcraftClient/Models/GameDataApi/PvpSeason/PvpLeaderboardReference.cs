using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP leaderboard.
    /// </summary>
    public class PvpLeaderboardReference
    {
        /// <summary>
        /// Gets the key for the PvP leaderboard.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP leaderboard.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP leaderboard.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
