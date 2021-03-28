using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature family.
    /// </summary>
    public record CreatureFamilyReference
    {
        /// <summary>
        /// Gets the key for the creature family.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the creature family.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureFamilyReference"/> class.
        /// </summary>
        /// <param name="key">The key for the creature family.</param>
        /// <param name="name">The name of the creature family.</param>
        /// <param name="id">The ID of the creature family.</param>
        [JsonConstructor]
        public CreatureFamilyReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
