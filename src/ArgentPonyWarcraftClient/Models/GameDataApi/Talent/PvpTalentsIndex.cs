using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP talents.
    /// </summary>
    public record PvpTalentsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to PvP talents.
        /// </summary>
        [JsonPropertyName("pvp_talents")]
        public PvpTalentReference[] PvpTalents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of PvP talents.</param>
        /// <param name="pvpTalents">References to PvP talents.</param>
        [JsonConstructor]
        public PvpTalentsIndex(Links links, PvpTalentReference[] pvpTalents)
        {
            Links = links;
            PvpTalents = pvpTalents;
        }
    }
}
