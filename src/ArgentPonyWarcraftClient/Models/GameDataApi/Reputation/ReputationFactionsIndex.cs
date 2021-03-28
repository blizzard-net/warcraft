using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of reputation factions.
    /// </summary>
    public record ReputationFactionsIndex
    {
        /// <summary>
        /// Gets links for the index of reputation factions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the factions.
        /// </summary>
        [JsonPropertyName("factions")]
        public ReputationFactionReference[] Factions { get; }

        /// <summary>
        /// Gets references to the root factions.
        /// </summary>
        [JsonPropertyName("root_factions")]
        public ReputationFactionReference[] RootFactions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationFactionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of reputation factions.</param>
        /// <param name="factions">References to the factions.</param>
        /// <param name="rootFactions">References to the root factions.</param>
        [JsonConstructor]
        public ReputationFactionsIndex(Links links, ReputationFactionReference[] factions, ReputationFactionReference[] rootFactions)
        {
            Links = links;
            Factions = factions;
            RootFactions = rootFactions;
        }
    }
}
