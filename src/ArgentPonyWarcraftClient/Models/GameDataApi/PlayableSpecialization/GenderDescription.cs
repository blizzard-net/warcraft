using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The gender-specific description for a playable specialization.
    /// </summary>
    public class GenderDescription
    {
        /// <summary>
        /// Gets the description for male characters of a playable specialization.
        /// </summary>
        [JsonPropertyName("male")]
        public string Male { get; set; }

        /// <summary>
        /// Gets the description for female characters of a playable specialization.
        /// </summary>
        [JsonPropertyName("female")]
        public string Female { get; set; }
    }
}
