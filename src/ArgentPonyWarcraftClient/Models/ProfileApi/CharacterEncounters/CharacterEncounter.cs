using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Encounter statistics for a character in an instance.
    /// </summary>
    public record CharacterEncounter
    {
        /// <summary>
        /// Gets a reference to the encounter.
        /// </summary>
        [JsonPropertyName("encounter")]
        public EncounterReference Encounter { get; }

        /// <summary>
        /// Gets the number of times the encounter has been completed by the character.
        /// </summary>
        [JsonPropertyName("completed_count")]
        public int CompletedCount { get; }

        /// <summary>
        /// Gets the timestamp of the last kill.
        /// </summary>
        [JsonPropertyName("last_kill_timestamp")]
        public DateTimeOffset LastKillTimestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEncounter"/> class.
        /// </summary>
        /// <param name="encounter">A reference to the encounter.</param>
        /// <param name="completedCount">The number of times the encounter has been completed by the character.</param>
        /// <param name="lastKillTimestamp">The timestamp of the last kill.</param>
        [JsonConstructor]
        public CharacterEncounter(EncounterReference encounter, int completedCount, DateTimeOffset lastKillTimestamp)
        {
            Encounter = encounter;
            CompletedCount = completedCount;
            LastKillTimestamp = lastKillTimestamp;
        }
    }
}
