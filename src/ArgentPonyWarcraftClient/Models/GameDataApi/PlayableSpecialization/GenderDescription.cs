using Newtonsoft.Json;

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
        [JsonProperty("male")]
        public string Male { get; set; }

        /// <summary>
        /// Gets the description for female characters of a playable specialization.
        /// </summary>
        [JsonProperty("female")]
        public string Female { get; set; }
    }
}
