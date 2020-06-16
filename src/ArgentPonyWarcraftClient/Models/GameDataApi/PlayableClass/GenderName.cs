using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The gender-specific names for a playable class.
    /// </summary>
    public class GenderName
    {
        /// <summary>
        /// Gets the class name for male characters of a playable class.
        /// </summary>
        [JsonProperty("male")]
        public string Male { get; set; }

        /// <summary>
        /// Gets the class name for female characters of a playable class.
        /// </summary>
        [JsonProperty("female")]
        public string Female { get; set; }
    }
}
