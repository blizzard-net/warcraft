using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of reputation tiers.
    /// </summary>
    public record ReputationTiersIndex
    {
        /// <summary>
        /// Gets links for the index of reputation tiers.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the reputation tiers.
        /// </summary>
        [JsonPropertyName("reputation_tiers")]
        public ReputationTierReference[] ReputationTiers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationTiersIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of reputation tiers.</param>
        /// <param name="reputationTiers">References to the reputation tiers.</param>
        [JsonConstructor]
        public ReputationTiersIndex(Links links, ReputationTierReference[] reputationTiers)
        {
            Links = links;
            ReputationTiers = reputationTiers;
        }
    }
}
