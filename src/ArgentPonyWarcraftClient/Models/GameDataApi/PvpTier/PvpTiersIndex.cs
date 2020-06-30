using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP tiers.
    /// </summary>
    public class PvpTiersIndex
    {
        /// <summary>
        /// Gets links for the index of PvP tiers.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the PvP tiers.
        /// </summary>
        [JsonProperty("tiers")]
        public PvpTierReference[] Tiers { get; set; }
    }
}
