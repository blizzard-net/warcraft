using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the region.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
