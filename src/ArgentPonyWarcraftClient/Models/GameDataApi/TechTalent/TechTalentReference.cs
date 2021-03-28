using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a tech talent.
    /// </summary>
    public record TechTalentReference
    {
        /// <summary>
        /// Gets the key for the tech talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the tech talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the tech talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentReference"/> class.
        /// </summary>
        /// <param name="key">The key for the tech talent.</param>
        /// <param name="name">The name of the tech talent.</param>
        /// <param name="id">The ID of the tech talent.</param>
        [JsonConstructor]
        public TechTalentReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
