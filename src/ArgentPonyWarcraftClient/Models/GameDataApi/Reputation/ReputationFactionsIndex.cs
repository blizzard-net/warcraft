using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of reputation factions.
    /// </summary>
    public class ReputationFactionsIndex
    {
        /// <summary>
        /// Gets links for the index of reputation factions.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the factions.
        /// </summary>
        [JsonProperty("factions")]
        public ReputationFactionReference[] Factions { get; set; }

        /// <summary>
        /// Gets references to the root factions.
        /// </summary>
        [JsonProperty("root_factions")]
        public ReputationFactionReference[] RootFactions { get; set; }
    }
}
