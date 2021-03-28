using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of regions.
    /// </summary>
    public record RegionsIndex
    {
        /// <summary>
        /// Gets links for the index of regions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the regions.
        /// </summary>
        [JsonPropertyName("regions")]
        public Self[] Regions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of regions.</param>
        /// <param name="regions">References to the regions.</param>
        [JsonConstructor]
        public RegionsIndex(Links links, Self[] regions)
        {
            Links = links;
            Regions = regions;
        }
    }
}
