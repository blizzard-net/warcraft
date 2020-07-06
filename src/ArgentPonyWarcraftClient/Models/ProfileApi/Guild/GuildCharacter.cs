using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

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
        /// Gets the level of the character.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets a reference to the character's class.
        /// </summary>
        [JsonProperty("playable_class")]
        public PlayableClassReferenceWithoutName PlayableClass { get; set; }

        /// <summary>
        /// Gets a reference to the character's race.
        /// </summary>
        [JsonProperty("playable_race")]
        public PlayableRaceReferenceWithoutName PlayableRace { get; set; }
    }
}
