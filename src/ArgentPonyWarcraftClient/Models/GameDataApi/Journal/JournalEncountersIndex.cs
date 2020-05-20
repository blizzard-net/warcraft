using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An index of boss encounters.
    /// </summary>
    public class JournalEncountersIndex
    {
        /// <summary>
        /// Gets links for the index of boss encounters.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the boss encounters.
        /// </summary>
        [JsonProperty("encounters")]
        public EncounterReference[] Encounters { get; set; }
    }
}
