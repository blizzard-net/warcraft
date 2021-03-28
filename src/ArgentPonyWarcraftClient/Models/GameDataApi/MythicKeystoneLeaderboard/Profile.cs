using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character profile.
    /// </summary>
    public record Profile
    {
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
        public RealmReferenceWithoutName Realm { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        [JsonConstructor]
        public Profile(string name, int id, RealmReferenceWithoutName realm)
        {
            Name = name;
            Id = id;
            Realm = realm;
        }
    }
}
