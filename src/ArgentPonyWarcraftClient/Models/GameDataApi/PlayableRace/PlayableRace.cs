using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable race.
    /// </summary>
    public class PlayableRace
    {
        /// <summary>
        /// Gets links for the playable race.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the playable race.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the playable race.
        /// </summary>
        [JsonProperty("gender_name")]
        public GenderName GenderName { get; set; }

        /// <summary>
        /// Gets the faction of the playable race (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets a value indicating whether the playable race can be selected.
        /// </summary>
        [JsonProperty("is_selectable")]
        public bool IsSelectable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the race is allied to a faction.
        /// </summary>
        [JsonProperty("is_allied_race")]
        public bool IsAlliedRace { get; set; }
    }
}
