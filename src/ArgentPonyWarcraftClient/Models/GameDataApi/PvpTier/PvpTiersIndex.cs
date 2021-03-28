using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the PvP tiers.
        /// </summary>
        [JsonPropertyName("tiers")]
        public PvpTierReference[] Tiers { get; set; }
    }
}
