using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable class.
    /// </summary>
    public record PlayableClass
    {
        /// <summary>
        /// Gets links for the playable class.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the gender-specific names for the playable class.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; }

        /// <summary>
        /// Gets a reference to the power type used by this playable class.
        /// </summary>
        [JsonPropertyName("power_type")]
        public PowerTypeReference PowerType { get; }

        /// <summary>
        /// Gets references to the specializations for this playable class.
        /// </summary>
        [JsonPropertyName("specializations")]
        public PlayableSpecializationReference[] Specializations { get; }

        /// <summary>
        /// Gets the media for this playable class.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets a link to the PVP talent slots for this playable class.
        /// </summary>
        [JsonPropertyName("pvp_talent_slots")]
        public Self PvpTalentSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableClass"/> class.
        /// </summary>
        /// <param name="links">Links for the playable class.</param>
        /// <param name="id">The ID of the playable class.</param>
        /// <param name="name">The name of the playable class.</param>
        /// <param name="genderName">The gender-specific names for the playable class.</param>
        /// <param name="powerType">A reference to the power type used by this playable class.</param>
        /// <param name="specializations">References to the specializations for this playable class.</param>
        /// <param name="media">The media for this playable class.</param>
        /// <param name="pvpTalentSlots">A link to the PVP talent slots for this playable class.</param>
        [JsonConstructor]
        public PlayableClass(Links links, int id, string name, GenderName genderName, PowerTypeReference powerType, PlayableSpecializationReference[] specializations, Media media, Self pvpTalentSlots)
        {
            Links = links;
            Id = id;
            Name = name;
            GenderName = genderName;
            PowerType = powerType;
            Specializations = specializations;
            Media = media;
            PvpTalentSlots = pvpTalentSlots;
        }
    }
}
