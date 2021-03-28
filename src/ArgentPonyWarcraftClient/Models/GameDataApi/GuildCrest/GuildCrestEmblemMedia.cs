using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a guild crest emblem.
    /// </summary>
    public record GuildCrestEmblemMedia
    {
        /// <summary>
        /// Gets links for the guild crest emblem media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the guild crest emblem.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestEmblemMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the guild crest emblem media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the guild crest emblem.</param>
        [JsonConstructor]
        public GuildCrestEmblemMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
