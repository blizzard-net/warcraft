using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a tech talent tree.
    /// </summary>
    public record TechTalentTreeReference
    {
        /// <summary>
        /// Gets the key for this tech talent tree.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the Id for this tech talent tree.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name for this tech talent tree.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentTreeReference"/> class.
        /// </summary>
        /// <param name="key">The key for this tech talent tree.</param>
        /// <param name="id">The Id for this tech talent tree.</param>
        /// <param name="name">The name for this tech talent tree.</param>
        [JsonConstructor]
        public TechTalentTreeReference(Self key, int id, string name)
        {
            Key = key;
            Id = id;
            Name = name;
        }
    }
}
