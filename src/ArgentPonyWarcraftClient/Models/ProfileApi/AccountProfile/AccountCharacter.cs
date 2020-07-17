using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character associated with a World of Warcraft account.
    /// </summary>
    public class AccountCharacter
    {
        /// <summary>
        /// Gets a link to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public Self Character { get; set; }

        /// <summary>
        /// Gets a link to the protected character information.
        /// </summary>
        [JsonPropertyName("protected_character")]
        public Self ProtectedCharacter { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonPropertyName("playable_race")]
        public PlayableClassReference PlayableRace { get; set; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonPropertyName("gender")]
        public EnumType Gender { get; set; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }
    }
}
