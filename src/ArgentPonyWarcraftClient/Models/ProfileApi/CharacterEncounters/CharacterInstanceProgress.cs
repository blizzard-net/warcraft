using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Instance progress for a character.
    /// </summary>
    public class CharacterInstanceProgress
    {
        /// <summary>
        /// Gets the number of times the instance has been completed by the character.
        /// </summary>
        [JsonProperty("completed_count")]
        public long CompletedCount { get; set; }

        /// <summary>
        /// Gets the number of times the instance has been attempted by the character.
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets encounter statistics for the instance.
        /// </summary>
        [JsonProperty("encounters")]
        public CharacterEncounter[] Encounters { get; set; }
    }
}
