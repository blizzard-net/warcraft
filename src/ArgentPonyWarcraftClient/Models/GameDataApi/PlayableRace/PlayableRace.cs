using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the playable race.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the playable race.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; set; }

        /// <summary>
        /// Gets the faction of the playable race (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets a value indicating whether the playable race can be selected.
        /// </summary>
        [JsonPropertyName("is_selectable")]
        public bool IsSelectable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the race is allied to a faction.
        /// </summary>
        [JsonPropertyName("is_allied_race")]
        public bool IsAlliedRace { get; set; }
    }
}
