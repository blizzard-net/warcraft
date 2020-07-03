using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of regions.
    /// </summary>
    public class RegionsIndex
    {
        /// <summary>
        /// Gets links for the index of regions.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the regions.
        /// </summary>
        [JsonProperty("regions")]
        public Self[] Regions { get; set; }
    }
}
