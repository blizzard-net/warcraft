using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a creature.
    /// </summary>
    public record CreatureReference
    {
        /// <summary>
        /// Gets the key for the creature.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureReference"/> class.
        /// </summary>
        /// <param name="key">The key for the creature.</param>
        /// <param name="name">The name of the creature.</param>
        /// <param name="id">The ID of the creature.</param>
        [JsonConstructor]
        public CreatureReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
