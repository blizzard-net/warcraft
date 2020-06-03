using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a character title.
    /// </summary>
    public class TitleReference
    {
        /// <summary>
        /// Gets the key for the title.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the display string for the title.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }
    }
}
