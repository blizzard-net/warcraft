using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of titles.
    /// </summary>
    public record TitlesIndex
    {
        /// <summary>
        /// Gets links for the index of titles.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the titles.
        /// </summary>
        [JsonPropertyName("titles")]
        public TitleReferenceWithDisplayString[] Titles { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitlesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of titles.</param>
        /// <param name="titles">References to the titles.</param>
        [JsonConstructor]
        public TitlesIndex(Links links, TitleReferenceWithDisplayString[] titles)
        {
            Links = links;
            Titles = titles;
        }
    }
}
