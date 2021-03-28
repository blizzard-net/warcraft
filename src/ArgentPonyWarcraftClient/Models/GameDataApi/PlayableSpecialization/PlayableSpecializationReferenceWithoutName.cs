using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable specialization.
    /// </summary>
    public record PlayableSpecializationReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the playable specialization.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableSpecializationReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the playable specialization.</param>
        /// <param name="id">The ID of the playable specialization.</param>
        [JsonConstructor]
        public PlayableSpecializationReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
