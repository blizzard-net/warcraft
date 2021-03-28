using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An instance that a character has completed in a difficulty mode.
    /// </summary>
    public record CharacterInstanceMode
    {
        /// <summary>
        /// Gets the difficulty level of the instance.
        /// </summary>
        [JsonPropertyName("difficulty")]
        public EnumType Difficulty { get; }

        /// <summary>
        /// Gets the status of the instance.
        /// </summary>
        [JsonPropertyName("status")]
        public EnumType Status { get; }

        /// <summary>
        /// Gets the character progress for the instance.
        /// </summary>
        [JsonPropertyName("progress")]
        public CharacterInstanceProgress Progress { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterInstanceMode"/> class.
        /// </summary>
        /// <param name="difficulty">The difficulty level of the instance.</param>
        /// <param name="status">The status of the instance.</param>
        /// <param name="progress">The character progress for the instance.</param>
        [JsonConstructor]
        public CharacterInstanceMode(EnumType difficulty, EnumType status, CharacterInstanceProgress progress)
        {
            Difficulty = difficulty;
            Status = status;
            Progress = progress;
        }
    }
}
