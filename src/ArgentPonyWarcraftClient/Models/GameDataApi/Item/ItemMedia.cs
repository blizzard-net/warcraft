using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item media.
    /// </summary>
    public record ItemMedia
    {
        /// <summary>
        /// Gets links for the achievement media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the achievement media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the item.</param>
        [JsonConstructor]
        public ItemMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
