using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An instance that a character has completed in a difficulty mode.
    /// </summary>
    public class CharacterInstanceMode
    {
        /// <summary>
        /// Gets the difficulty level of the instance.
        /// </summary>
        [JsonPropertyName("difficulty")]
        public EnumType Difficulty { get; set; }

        /// <summary>
        /// Gets the status of the instance.
        /// </summary>
        [JsonPropertyName("status")]
        public EnumType Status { get; set; }

        /// <summary>
        /// Gets the character progress for the instance.
        /// </summary>
        [JsonPropertyName("progress")]
        public CharacterInstanceProgress Progress { get; set; }
    }
}
