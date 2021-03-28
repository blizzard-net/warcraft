using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Instance progress for a character.
    /// </summary>
    public record CharacterInstanceProgress
    {
        /// <summary>
        /// Gets the number of times the instance has been completed by the character.
        /// </summary>
        [JsonPropertyName("completed_count")]
        public int CompletedCount { get; }

        /// <summary>
        /// Gets the number of times the instance has been attempted by the character.
        /// </summary>
        [JsonPropertyName("total_count")]
        public int TotalCount { get; }

        /// <summary>
        /// Gets encounter statistics for the instance.
        /// </summary>
        [JsonPropertyName("encounters")]
        public CharacterEncounter[] Encounters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterInstanceProgress"/> class.
        /// </summary>
        /// <param name="completedCount">The number of times the instance has been completed by the character.</param>
        /// <param name="totalCount">The number of times the instance has been attempted by the character.</param>
        /// <param name="encounters">Encounter statistics for the instance.</param>
        [JsonConstructor]
        public CharacterInstanceProgress(int completedCount, int totalCount, CharacterEncounter[] encounters)
        {
            CompletedCount = completedCount;
            TotalCount = totalCount;
            Encounters = encounters;
        }
    }
}
