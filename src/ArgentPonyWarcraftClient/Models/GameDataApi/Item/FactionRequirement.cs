using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A faction requirement for an item.
    /// </summary>
    public class FactionRequirement
    {
        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonProperty("value")]
        public EnumType Value { get; set; }

        /// <summary>
        /// Gets the display string for the faction requirement.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }
    }
}
