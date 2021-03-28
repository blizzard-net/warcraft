using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Playable class media.
    /// </summary>
    public record PlayableClassMedia
    {
        /// <summary>
        /// Gets links for the playable class media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableClassMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the playable class media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the playable class.</param>
        [JsonConstructor]
        public PlayableClassMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
