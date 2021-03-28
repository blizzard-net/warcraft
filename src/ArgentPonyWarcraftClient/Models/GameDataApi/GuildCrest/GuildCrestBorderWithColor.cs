using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest border with color.
    /// </summary>
    public record GuildCrestBorderWithColor
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
        /// Gets the border color.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestBorderWithColor"/> class.
        /// </summary>
        /// <param name="id">The ID of the border.</param>
        /// <param name="media">The media associated with the border.</param>
        /// <param name="color">The border color.</param>
        [JsonConstructor]
        public GuildCrestBorderWithColor(int id, Media media, Color color)
        {
            Id = id;
            Media = media;
            Color = color;
        }
    }
}
