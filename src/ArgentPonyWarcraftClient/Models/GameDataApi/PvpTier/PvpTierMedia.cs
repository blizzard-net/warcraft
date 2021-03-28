using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP tier media.
    /// </summary>
    public record PvpTierMedia
    {
        /// <summary>
        /// Gets links for the PvP tier media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTierMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP tier media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the PvP tier.</param>
        [JsonConstructor]
        public PvpTierMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
