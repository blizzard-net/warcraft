using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature type.
    /// </summary>
    public record CreatureTypeReference
    {
        /// <summary>
        /// Gets the key for the creature type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureTypeReference"/> class.
        /// </summary>
        /// <param name="key">The key for the creature type.</param>
        /// <param name="name">The name of the creature type.</param>
        /// <param name="id">The ID of the creature type.</param>
        [JsonConstructor]
        public CreatureTypeReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
