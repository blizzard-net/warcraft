using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set bonus that can be activated by equipping items from the set.
    /// </summary>
    public class Effect
    {
        /// <summary>
        /// Gets the display string for the effect.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the required count of items in the set that must be equipped to activate the effect.
        /// </summary>
        [JsonProperty("required_count")]
        public long RequiredCount { get; set; }
    }
}
