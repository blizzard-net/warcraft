using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Gets a name description modifier for an item.
    /// </summary>
    public class NameDescription
    {
        /// <summary>
        /// Gets the display string for the 
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the RGBA color information.
        /// </summary>
        [JsonProperty("color")]
        public ColorDetails Color { get; set; }
    }
}
