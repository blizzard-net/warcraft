using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The gender-specific names for a playable class, race, or title.
    /// </summary>
    public class GenderName
    {
        /// <summary>
        /// Gets the name for male characters.
        /// </summary>
        [JsonPropertyName("male")]
        public string Male { get; set; }

        /// <summary>
        /// Gets the name for female characters.
        /// </summary>
        [JsonPropertyName("female")]
        public string Female { get; set; }
    }
}
