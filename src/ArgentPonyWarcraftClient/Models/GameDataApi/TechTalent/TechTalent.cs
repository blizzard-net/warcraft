using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tech talent.
    /// </summary>
    public record TechTalent
    {
        /// <summary>
        /// Gets links for the tech talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the Id for the tech talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the tech talent tree reference for the tech talent.
        /// </summary>
        [JsonPropertyName("talent_tree")]
        public TechTalentTreeReference TalentTree { get; }

        /// <summary>
        /// Gets the name for the tech talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets a description for the tech talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the spell tooltip for this tech talent.
        /// </summary>
        [JsonPropertyName("spell_tooltip")]
        public SpellTooltipForAbility SpellTooltip { get; }

        /// <summary>
        /// Gets the tier for the tech talent.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; }

        /// <summary>
        /// Gets the display order for the tech talent.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; }

        /// <summary>
        /// Gets the prerequisite talent for the tech talent.
        /// </summary>
        [JsonPropertyName("prerequisite_talent")]
        public TalentReferenceWithoutName PrerequisiteTalent { get; }

        /// <summary>
        /// Gets the media for the tech talent.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalent"/> class.
        /// </summary>
        /// <param name="links">Links for the tech talent.</param>
        /// <param name="id">The Id for the tech talent.</param>
        /// <param name="talentTree">The tech talent tree reference for the tech talent.</param>
        /// <param name="name">The name for the tech talent.</param>
        /// <param name="description">A description for the tech talent.</param>
        /// <param name="spellTooltip">The spell tooltip for this tech talent.</param>
        /// <param name="tier">The tier for the tech talent.</param>
        /// <param name="displayOrder">The display order for the tech talent.</param>
        /// <param name="prerequisiteTalent">The prerequisite talent for the tech talent.</param>
        /// <param name="media">The media for the tech talent.</param>
        [JsonConstructor]
        public TechTalent(Links links, int id, TechTalentTreeReference talentTree, string name, string description, SpellTooltipForAbility spellTooltip, int tier, int displayOrder, TalentReferenceWithoutName prerequisiteTalent, Media media)
        {
            Links = links;
            Id = id;
            TalentTree = talentTree;
            Name = name;
            Description = description;
            SpellTooltip = spellTooltip;
            Tier = tier;
            DisplayOrder = displayOrder;
            PrerequisiteTalent = prerequisiteTalent;
            Media = media;
        }
    }
}
