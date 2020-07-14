using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set of reputation tiers.
    /// </summary>
    public class ReputationTiers
    {
        /// <summary>
        /// Gets links for the set of reputation tiers.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the set of reputation tiers.
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the reputation tiers.
        /// </summary>
        [JsonProperty("tiers")]
        public ReputationTier[] Tiers { get; set; }

        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonProperty("faction")]
        public ReputationFactionReference Faction { get; set; }
    }
}
