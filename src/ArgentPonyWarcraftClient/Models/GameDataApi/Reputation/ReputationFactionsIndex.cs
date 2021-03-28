using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the factions.
        /// </summary>
        [JsonPropertyName("factions")]
        public ReputationFactionReference[] Factions { get; set; }

        /// <summary>
        /// Gets references to the root factions.
        /// </summary>
        [JsonPropertyName("root_factions")]
        public ReputationFactionReference[] RootFactions { get; set; }
    }
}
