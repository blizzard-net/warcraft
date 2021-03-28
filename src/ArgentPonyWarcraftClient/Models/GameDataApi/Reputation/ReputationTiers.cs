using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set of reputation tiers.
    /// </summary>
    public record ReputationTiers
    {
        /// <summary>
        /// Gets links for the set of reputation tiers.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the set of reputation tiers.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the reputation tiers.
        /// </summary>
        [JsonPropertyName("tiers")]
        public ReputationTier[] Tiers { get; }

        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public ReputationFactionReference Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationTiers"/> class.
        /// </summary>
        /// <param name="links">Links for the set of reputation tiers.</param>
        /// <param name="id">The ID of the set of reputation tiers.</param>
        /// <param name="tiers">The reputation tiers.</param>
        /// <param name="faction">A reference to the reputation faction.</param>
        [JsonConstructor]
        public ReputationTiers(Links links, int id, ReputationTier[] tiers, ReputationFactionReference faction)
        {
            Links = links;
            Id = id;
            Tiers = tiers;
            Faction = faction;
        }
    }
}
