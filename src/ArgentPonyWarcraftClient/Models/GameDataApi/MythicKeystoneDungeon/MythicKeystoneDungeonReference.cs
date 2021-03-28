using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone dungeon.
    /// </summary>
    public record MythicKeystoneDungeonReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneDungeonReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Mythic Keystone dungeon.</param>
        /// <param name="name">The name of the Mythic Keystone dungeon.</param>
        /// <param name="id">The ID of the Mythic Keystone dungeon.</param>
        [JsonConstructor]
        public MythicKeystoneDungeonReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
