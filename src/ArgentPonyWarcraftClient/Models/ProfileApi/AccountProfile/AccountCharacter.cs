using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character associated with a World of Warcraft account.
    /// </summary>
    public record AccountCharacter
    {
        /// <summary>
        /// Gets a link to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public Self Character { get; }

        /// <summary>
        /// Gets a link to the protected character information.
        /// </summary>
        [JsonPropertyName("protected_character")]
        public Self ProtectedCharacter { get; }

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
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonPropertyName("playable_race")]
        public PlayableClassReference PlayableRace { get; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonPropertyName("gender")]
        public EnumType Gender { get; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCharacter"/> class.
        /// </summary>
        /// <param name="character">A link to the character.</param>
        /// <param name="protectedCharacter">A link to the protected character information.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        /// <param name="playableClass">A reference to the character's class.</param>
        /// <param name="playableRace">A reference to the character's race.</param>
        /// <param name="gender">The gender of the character.</param>
        /// <param name="faction">The faction of the character (Alliance or Horde).</param>
        /// <param name="level">The level of the character.</param>
        [JsonConstructor]
        public AccountCharacter(Self character, Self protectedCharacter, string name, int id, RealmReference realm, PlayableClassReference playableClass, PlayableClassReference playableRace, EnumType gender, EnumType faction, int level)
        {
            Character = character;
            ProtectedCharacter = protectedCharacter;
            Name = name;
            Id = id;
            Realm = realm;
            PlayableClass = playableClass;
            PlayableRace = playableRace;
            Gender = gender;
            Faction = faction;
            Level = level;
        }
    }
}
