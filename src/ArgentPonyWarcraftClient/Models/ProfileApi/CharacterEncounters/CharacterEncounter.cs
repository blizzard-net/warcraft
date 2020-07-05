using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Encounter statistics for a character in an instance.
    /// </summary>
    public class CharacterEncounter
    {
        /// <summary>
        /// Gets a reference to the encounter.
        /// </summary>
        [JsonProperty("encounter")]
        public EncounterReference Encounter { get; set; }

        /// <summary>
        /// Gets the number of times the encounter has been completed by the character.
        /// </summary>
        [JsonProperty("completed_count")]
        public long CompletedCount { get; set; }

        /// <summary>
        /// Gets the timestamp of the last kill.
        /// </summary>
        [JsonProperty("last_kill_timestamp")]
        public DateTime LastKillTimestamp { get; set; }
    }
}
