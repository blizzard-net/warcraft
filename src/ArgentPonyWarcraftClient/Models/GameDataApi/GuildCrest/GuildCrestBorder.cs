using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest border.
    /// </summary>
    public record GuildCrestBorder
    {
        /// <summary>
        /// Gets the ID of the border.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the media associated with the border.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestBorder"/> class.
        /// </summary>
        /// <param name="id">The ID of the border.</param>
        /// <param name="media">The media associated with the border.</param>
        [JsonConstructor]
        public GuildCrestBorder(int id, Media media)
        {
            Id = id;
            Media = media;
        }
    }
}
