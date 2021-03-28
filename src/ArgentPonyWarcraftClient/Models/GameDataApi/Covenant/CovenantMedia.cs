using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a covenant.
    /// </summary>
    public record CovenantMedia
    {
        /// <summary>
        /// Gets the key for this covenant media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantMedia"/> class.
        /// </summary>
        /// <param name="links">The key for this covenant media.</param>
        /// <param name="assets">A collection of media assets.</param>
        [JsonConstructor]
        public CovenantMedia(Links links, Asset[] assets)
        {
            Links = links;
            Assets = assets;
        }
    }
}
