using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a tech talent.
    /// </summary>
    public record TechTalentMedia
    {
        /// <summary>
        /// Gets links for the tech talent media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the tech talent media.</param>
        /// <param name="assets">A collection media assets.</param>
        [JsonConstructor]
        public TechTalentMedia(Links links, Asset[] assets)
        {
            Links = links;
            Assets = assets;
        }
    }
}
