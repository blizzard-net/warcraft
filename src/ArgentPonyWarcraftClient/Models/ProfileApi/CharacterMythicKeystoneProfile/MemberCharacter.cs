using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character who is a party member.
    /// </summary>
    public record MemberCharacter
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
        /// Initializes a new instance of the <see cref="MemberCharacter"/> class.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        [JsonConstructor]
        public MemberCharacter(string name, int id, RealmReferenceWithoutName realm)
        {
            Name = name;
            Id = id;
            Realm = realm;
        }
    }
}
