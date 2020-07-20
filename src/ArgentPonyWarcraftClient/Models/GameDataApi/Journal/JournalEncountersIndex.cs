using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of boss encounters.
    /// </summary>
    public class JournalEncountersIndex
    {
        /// <summary>
        /// Gets links for the index of boss encounters.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the boss encounters.
        /// </summary>
        [JsonPropertyName("encounters")]
        public EncounterReference[] Encounters { get; set; }
    }
}
