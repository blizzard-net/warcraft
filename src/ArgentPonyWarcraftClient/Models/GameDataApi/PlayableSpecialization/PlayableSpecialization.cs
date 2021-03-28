using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A playable specialization.
    /// </summary>
    public record PlayableSpecialization
    {
        /// <summary>
        /// Gets links for the playable specialization.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the playable class associated with this specialization.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; }

        /// <summary>
        /// Gets the name of the playable specialization.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the gender-specific descriptions for the playable specialization.
        /// </summary>
        [JsonPropertyName("gender_description")]
        public GenderDescription GenderDescription { get; }

        /// <summary>
        /// Get the media associated with the playable specialization.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets the role associated with the playable specialization.
        /// </summary>
        [JsonPropertyName("role")]
        public EnumType Role { get; }

        /// <summary>
        /// Gets the talent tiers for the playable specialization.
        /// </summary>
        [JsonPropertyName("talent_tiers")]
        public TalentTier[] TalentTiers { get; }

        /// <summary>
        /// Gets the PvP talents for the playable specialization.
        /// </summary>
        [JsonPropertyName("pvp_talents")]
        public PvpTalentElement[] PvpTalents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableSpecialization"/> class.
        /// </summary>
        /// <param name="links">Links for the playable specialization.</param>
        /// <param name="id">The ID of the playable specialization.</param>
        /// <param name="playableClass">A reference to the playable class associated with this specialization.</param>
        /// <param name="name">The name of the playable specialization.</param>
        /// <param name="genderDescription">The gender-specific descriptions for the playable specialization.</param>
        /// <param name="media">The gender-specific descriptions for the playable specialization.</param>
        /// <param name="role">The role associated with the playable specialization.</param>
        /// <param name="talentTiers">The talent tiers for the playable specialization.</param>
        /// <param name="pvpTalents">The PvP talents for the playable specialization.</param>
        [JsonConstructor]
        public PlayableSpecialization(Links links, int id, PlayableClassReference playableClass, string name, GenderDescription genderDescription, Media media, EnumType role, TalentTier[] talentTiers, PvpTalentElement[] pvpTalents)
        {
            Links = links;
            Id = id;
            PlayableClass = playableClass;
            Name = name;
            GenderDescription = genderDescription;
            Media = media;
            Role = role;
            TalentTiers = talentTiers;
            PvpTalents = pvpTalents;
        }
    }
}
