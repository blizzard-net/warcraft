using Newtonsoft.Json;

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
        [JsonProperty("character")]
        public Self Character { get; set; }

        /// <summary>
        /// Gets a link to the protected character information.
        /// </summary>
        [JsonProperty("protected_character")]
        public Self ProtectedCharacter { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonProperty("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonProperty("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonProperty("playable_race")]
        public PlayableClassReference PlayableRace { get; set; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonProperty("gender")]
        public EnumType Gender { get; set; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }
    }
}
