using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable specialization.
    /// </summary>
    public class PlayableSpecialization
    {
        /// <summary>
        /// Gets links for the playable specialization.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the playable class associated with this specialization.
        /// </summary>
        [JsonProperty("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }

        /// <summary>
        /// Gets the name of the playable specialization.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific descriptions for the playable specialization.
        /// </summary>
        [JsonProperty("gender_description")]
        public GenderDescription GenderDescription { get; set; }

        /// <summary>
        /// Get the media associated with the playable specialization.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the role associated with the playable specialization.
        /// </summary>
        [JsonProperty("role")]
        public EnumType Role { get; set; }

        /// <summary>
        /// Gets the talent tiers for the playable specialization.
        /// </summary>
        [JsonProperty("talent_tiers")]
        public TalentTier[] TalentTiers { get; set; }

        /// <summary>
        /// Gets the PvP talents for the playable specialization.
        /// </summary>
        [JsonProperty("pvp_talents")]
        public PvpTalentElement[] PvpTalents { get; set; }
    }
}
