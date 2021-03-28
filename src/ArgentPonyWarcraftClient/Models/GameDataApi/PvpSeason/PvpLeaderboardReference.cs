using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
