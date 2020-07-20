using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the set of reputation tiers.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the reputation tiers.
        /// </summary>
        [JsonPropertyName("tiers")]
        public ReputationTier[] Tiers { get; set; }

        /// <summary>
        /// Gets a reference to the reputation faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public ReputationFactionReference Faction { get; set; }
    }
}
