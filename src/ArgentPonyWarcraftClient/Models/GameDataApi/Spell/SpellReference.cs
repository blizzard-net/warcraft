using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a spell.
    /// </summary>
    public record SpellReference
    {
        /// <summary>
        /// Gets the key for the spell.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the spell.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellReference"/> class.
        /// </summary>
        /// <param name="key">The key for the spell.</param>
        /// <param name="name">The name of the spell.</param>
        /// <param name="id">The ID of the spell.</param>
        [JsonConstructor]
        public SpellReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
