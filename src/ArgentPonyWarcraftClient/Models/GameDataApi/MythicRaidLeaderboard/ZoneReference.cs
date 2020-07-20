using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the zone.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
