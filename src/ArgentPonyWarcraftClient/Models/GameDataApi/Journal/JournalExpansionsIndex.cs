using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of game expansions.
    /// </summary>
    public class JournalExpansionsIndex
    {
        /// <summary>
        /// Gets links for the index of game expansions.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the tiers of content for the game expansions.
        /// </summary>
        [JsonProperty("tiers")]
        public Tier[] Tiers { get; set; }
    }
}
