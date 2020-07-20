using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a region.
    /// </summary>
    public class RegionReference
    {
        /// <summary>
        /// Gets the key for the region.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the region.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
