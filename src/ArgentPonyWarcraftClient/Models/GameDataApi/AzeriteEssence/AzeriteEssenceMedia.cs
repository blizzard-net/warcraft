using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for an azerite essence.
    /// </summary>
    public record AzeriteEssenceMedia
    {
        /// <summary>
        /// Gets links for the azerite essence media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeriteEssenceMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the azerite essence media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the azerite essence.</param>
        [JsonConstructor]
        public AzeriteEssenceMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
