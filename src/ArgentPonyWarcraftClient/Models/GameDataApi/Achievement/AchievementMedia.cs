using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement media.
    /// </summary>
    public record AchievementMedia
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
        /// Gets the Id of the achievement that the media belongs to.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the achievement media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The Id of the achievement that the media belongs to.</param>
        [JsonConstructor]
        public AchievementMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
