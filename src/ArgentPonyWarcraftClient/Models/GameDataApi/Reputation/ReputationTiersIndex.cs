using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of reputation tiers.
    /// </summary>
    public class ReputationTiersIndex
    {
        /// <summary>
        /// Gets links for the index of reputation tiers.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the reputation tiers.
        /// </summary>
        [JsonPropertyName("reputation_tiers")]
        public ReputationTierReference[] ReputationTiers { get; set; }
    }
}
