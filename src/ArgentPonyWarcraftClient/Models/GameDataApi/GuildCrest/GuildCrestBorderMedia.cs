using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a guild crest border.
    /// </summary>
    public record GuildCrestBorderMedia
    {
        /// <summary>
        /// Gets links for the guild crest border media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the guild crest border.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestBorderMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the guild crest border media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the guild crest border.</param>
        [JsonConstructor]
        public GuildCrestBorderMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
