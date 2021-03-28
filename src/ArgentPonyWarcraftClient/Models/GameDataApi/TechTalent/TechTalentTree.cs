using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tech talent tree.
    /// </summary>
    public record TechTalentTree
    {
        /// <summary>
        /// Gets links for the tech talent tree.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the Id for the tech talent tree.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// The maximum tiers of the talent tree.
        /// </summary>
        [JsonPropertyName("max_tiers")]
        public int MaxTiers { get; }

        /// <summary>
        /// The collection of talents in the tech talent tree.
        /// </summary>
        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentTree"/> class.
        /// </summary>
        /// <param name="links">Links for the tech talent tree.</param>
        /// <param name="id">The Id for the tech talent tree.</param>
        /// <param name="maxTiers">The Id for the tech talent tree.</param>
        /// <param name="talents">The Id for the tech talent tree.</param>
        [JsonConstructor]
        public TechTalentTree(Links links, int id, int maxTiers, TechTalentReference[] talents)
        {
            Links = links;
            Id = id;
            MaxTiers = maxTiers;
            Talents = talents;
        }
    }
}
