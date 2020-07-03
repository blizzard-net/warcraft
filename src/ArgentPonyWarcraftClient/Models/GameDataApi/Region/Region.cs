using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A region.
    /// </summary>
    public class RegionData
    {
        /// <summary>
        /// Gets links for the region.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the region.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the tag for the region.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
