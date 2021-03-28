using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Playable specialization media.
    /// </summary>
    public record PlayableSpecializationMedia
    {
        /// <summary>
        /// Gets links for the playable specialization media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableSpecializationMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the playable specialization media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the playable specialization.</param>
        [JsonConstructor]
        public PlayableSpecializationMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
