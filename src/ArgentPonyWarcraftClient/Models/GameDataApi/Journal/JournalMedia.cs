using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Journal instance media.
    /// </summary>
    public record JournalInstanceMedia
    {
        /// <summary>
        /// Gets links for the journal instance media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JournalInstanceMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the journal instance media.</param>
        /// <param name="assets">A collection of media assets.</param>
        [JsonConstructor]
        public JournalInstanceMedia(Links links, Asset[] assets)
        {
            Links = links;
            Assets = assets;
        }
    }
}
