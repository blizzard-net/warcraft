using Newtonsoft.Json;

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
        [JsonProperty("difficulty")]
        public EnumType Difficulty { get; set; }

        /// <summary>
        /// Gets the status of the instance.
        /// </summary>
        [JsonProperty("status")]
        public EnumType Status { get; set; }

        /// <summary>
        /// Gets the character progress for the instance.
        /// </summary>
        [JsonProperty("progress")]
        public CharacterInstanceProgress Progress { get; set; }
    }
}
