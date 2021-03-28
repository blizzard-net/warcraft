using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a soulbind.
    /// </summary>
    public record SoulbindReference
    {
        /// <summary>
        /// Gets the key for the soulbind.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the soulbind.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the soulbind.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoulbindReference"/> class.
        /// </summary>
        /// <param name="key">The key for the soulbind.</param>
        /// <param name="name">The name of the soulbind.</param>
        /// <param name="id">The ID of the soulbind.</param>
        [JsonConstructor]
        public SoulbindReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
