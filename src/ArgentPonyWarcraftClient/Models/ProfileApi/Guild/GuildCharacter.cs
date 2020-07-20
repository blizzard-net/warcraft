using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character summary for a guild member.
    /// </summary>
    public class GuildCharacter
    {
        /// <summary>
        /// Gets a link to the character's profile.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

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
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReferenceWithoutName PlayableClass { get; set; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonPropertyName("playable_race")]
        public PlayableRaceReferenceWithoutName PlayableRace { get; set; }
    }
}
