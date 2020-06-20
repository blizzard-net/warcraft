using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a zone.
    /// </summary>
    public class ZoneReference
    {
        /// <summary>
        /// Gets the key for the zone.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the zone.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
