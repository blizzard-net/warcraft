using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the titles.
        /// </summary>
        [JsonPropertyName("titles")]
        public TitleReferenceWithDisplayString[] Titles { get; set; }
    }
}
