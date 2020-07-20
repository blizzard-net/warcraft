using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the regions.
        /// </summary>
        [JsonPropertyName("regions")]
        public Self[] Regions { get; set; }
    }
}
