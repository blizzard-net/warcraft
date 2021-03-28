using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable class.
    /// </summary>
    public record PlayableClassReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the playable class.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableClassReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the playable class.</param>
        /// <param name="id">The ID of the playable class.</param>
        [JsonConstructor]
        public PlayableClassReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
