using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP tiers.
    /// </summary>
    public record PvpTiersIndex
    {
        /// <summary>
        /// Gets links for the index of PvP tiers.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the PvP tiers.
        /// </summary>
        [JsonPropertyName("tiers")]
        public PvpTierReference[] Tiers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTiersIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of PvP tiers.</param>
        /// <param name="tiers">References to the PvP tiers.</param>
        [JsonConstructor]
        public PvpTiersIndex(Links links, PvpTierReference[] tiers)
        {
            Links = links;
            Tiers = tiers;
        }
    }
}
