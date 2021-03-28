using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP leaderboard.
    /// </summary>
    public record PvpLeaderboardReference
    {
        /// <summary>
        /// Gets the key for the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the PvP leaderboard.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpLeaderboardReference"/> class.
        /// </summary>
        /// <param name="key">The key for the PvP leaderboard.</param>
        /// <param name="name">The name of the PvP leaderboard.</param>
        /// <param name="id">The ID of the PvP leaderboard.</param>
        [JsonConstructor]
        public PvpLeaderboardReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
