using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a character.
    /// </summary>
    public record CharacterReference
    {
        /// <summary>
        /// Gets the key for the character.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReference"/> class.
        /// </summary>
        /// <param name="key">The key for the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        [JsonConstructor]
        public CharacterReference(Self key, string name, int id, RealmReference realm)
        {
            Key = key;
            Name = name;
            Id = id;
            Realm = realm;
        }
    }
}
