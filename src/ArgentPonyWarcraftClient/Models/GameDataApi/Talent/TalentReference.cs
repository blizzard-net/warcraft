using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public record TalentReference
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentReference"/> class.
        /// </summary>
        /// <param name="key">The key for the talent.</param>
        /// <param name="name">The name of the talent.</param>
        /// <param name="id">The ID of the talent.</param>
        [JsonConstructor]
        public TalentReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
