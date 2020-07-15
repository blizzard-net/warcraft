using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of titles.
    /// </summary>
    public class TitlesIndex
    {
        /// <summary>
        /// Gets links for the index of titles.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the titles.
        /// </summary>
        [JsonProperty("titles")]
        public TitleReferenceWithDisplayString[] Titles { get; set; }
    }
}
