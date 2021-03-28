using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("encounter")]
        public EncounterReference Encounter { get; set; }

        /// <summary>
        /// Gets the number of times the encounter has been completed by the character.
        /// </summary>
        [JsonPropertyName("completed_count")]
        public int CompletedCount { get; set; }

        /// <summary>
        /// Gets the timestamp of the last kill.
        /// </summary>
        [JsonPropertyName("last_kill_timestamp")]
        public DateTimeOffset LastKillTimestamp { get; set; }
    }
}
