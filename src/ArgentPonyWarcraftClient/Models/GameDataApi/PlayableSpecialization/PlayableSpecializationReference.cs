using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable specialization.
    /// </summary>
    public record PlayableSpecializationReference
    {
        /// <summary>
        /// Gets the key for the playable specialization.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the playable specialization.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableSpecializationReference"/> class.
        /// </summary>
        /// <param name="key">The key for the playable specialization.</param>
        /// <param name="name">The name of the playable specialization.</param>
        /// <param name="id">The ID of the playable specialization.</param>
        [JsonConstructor]
        public PlayableSpecializationReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
