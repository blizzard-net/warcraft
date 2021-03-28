using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable class.
    /// </summary>
    public record PlayableClassReference
    {
        /// <summary>
        /// Gets the key for the playable class.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableClassReference"/> class.
        /// </summary>
        /// <param name="key">The key for the playable class.</param>
        /// <param name="name">The name of the playable class.</param>
        /// <param name="id">The ID of the playable class.</param>
        [JsonConstructor]
        public PlayableClassReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
