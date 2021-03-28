using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a boss encounter in a dungeon or raid.
    /// </summary>
    public record EncounterReference
    {
        /// <summary>
        /// Gets the key for the encounter.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the encounter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the encounter.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncounterReference"/> class.
        /// </summary>
        /// <param name="key">The key for the encounter.</param>
        /// <param name="name">The name of the encounter.</param>
        /// <param name="id">The ID of the encounter.</param>
        [JsonConstructor]
        public EncounterReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
