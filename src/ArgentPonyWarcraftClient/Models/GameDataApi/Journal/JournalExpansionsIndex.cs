using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of game expansions.
    /// </summary>
    public record JournalExpansionsIndex
    {
        /// <summary>
        /// Gets links for the index of game expansions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the tiers of content for the game expansions.
        /// </summary>
        [JsonPropertyName("tiers")]
        public Tier[] Tiers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JournalExpansionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of game expansions.</param>
        /// <param name="tiers">The tiers of content for the game expansions.</param>
        [JsonConstructor]
        public JournalExpansionsIndex(Links links, Tier[] tiers)
        {
            Links = links;
            Tiers = tiers;
        }
    }
}
