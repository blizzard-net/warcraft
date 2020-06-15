using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the playable class.
        /// </summary>
        [JsonProperty("gender_name")]
        public GenderName GenderName { get; set; }

        /// <summary>
        /// Gets a reference to the power type used by this playable class.
        /// </summary>
        [JsonProperty("power_type")]
        public PowerTypeReference PowerType { get; set; }

        /// <summary>
        /// Gets references to the specializations for this playable class.
        /// </summary>
        [JsonProperty("specializations")]
        public PlayableSpecializationReference[] Specializations { get; set; }

        /// <summary>
        /// Gets the media for this playable class.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets a link to the PVP talent slots for this playable class.
        /// </summary>
        [JsonProperty("pvp_talent_slots")]
        public Self PvpTalentSlots { get; set; }
    }
}
