using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable class.
    /// </summary>
    public class PlayableClass
    {
        /// <summary>
        /// Gets links for the playable class.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the playable class.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; set; }

        /// <summary>
        /// Gets a reference to the power type used by this playable class.
        /// </summary>
        [JsonPropertyName("power_type")]
        public PowerTypeReference PowerType { get; set; }

        /// <summary>
        /// Gets references to the specializations for this playable class.
        /// </summary>
        [JsonPropertyName("specializations")]
        public PlayableSpecializationReference[] Specializations { get; set; }

        /// <summary>
        /// Gets the media for this playable class.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets a link to the PVP talent slots for this playable class.
        /// </summary>
        [JsonPropertyName("pvp_talent_slots")]
        public Self PvpTalentSlots { get; set; }
    }
}
