using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable race.
    /// </summary>
    public record PlayableRaceReference
    {
        /// <summary>
        /// Gets the key for the playable race.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the playable race.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableRaceReference"/> class.
        /// </summary>
        /// <param name="key">The key for the playable race.</param>
        /// <param name="name">The name of the playable race.</param>
        /// <param name="id">The ID of the playable race.</param>
        [JsonConstructor]
        public PlayableRaceReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
