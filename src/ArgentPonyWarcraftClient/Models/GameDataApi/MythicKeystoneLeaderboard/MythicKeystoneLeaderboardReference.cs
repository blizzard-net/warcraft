using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone Leaderboard dungeon instance for a connected realm.
    /// </summary>
    public record MythicKeystoneLeaderboardReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneLeaderboardReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Mythic Keystone Leaderboard.</param>
        /// <param name="name">The name of the Mythic Keystone Leaderboard.</param>
        /// <param name="id">The ID of the Mythic Keystone Leaderboard.</param>
        [JsonConstructor]
        public MythicKeystoneLeaderboardReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
