using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the reputation tiers.
        /// </summary>
        [JsonProperty("reputation_tiers")]
        public ReputationTierReference[] ReputationTiers { get; set; }
    }
}
