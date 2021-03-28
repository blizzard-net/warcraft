using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character summary for a guild member.
    /// </summary>
    public record GuildCharacter
    {
        /// <summary>
        /// Gets a link to the character's profile.
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
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReferenceWithoutName PlayableClass { get; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonPropertyName("playable_race")]
        public PlayableRaceReferenceWithoutName PlayableRace { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCharacter"/> class.
        /// </summary>
        /// <param name="key">A link to the character's profile.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="realm">A reference to the character's realm.</param>
        /// <param name="level">The level of the character.</param>
        /// <param name="playableClass">A reference to the character's class.</param>
        /// <param name="playableRace">A reference to the character's race.</param>
        [JsonConstructor]
        public GuildCharacter(Self key, string name, int id, RealmReference realm, int level, PlayableClassReferenceWithoutName playableClass, PlayableRaceReferenceWithoutName playableRace)
        {
            Key = key;
            Name = name;
            Id = id;
            Realm = realm;
            Level = level;
            PlayableClass = playableClass;
            PlayableRace = playableRace;
        }
    }
}
