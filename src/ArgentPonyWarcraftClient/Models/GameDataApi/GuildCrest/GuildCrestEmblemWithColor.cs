using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest emblem with color.
    /// </summary>
    public record GuildCrestEmblemWithColor
    {
        /// <summary>
        /// Gets the ID of the emblem.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the media associated with the emblem.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets the emblem color.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestEmblemWithColor"/> class.
        /// </summary>
        /// <param name="id">The ID of the emblem.</param>
        /// <param name="media">The media associated with the emblem.</param>
        /// <param name="color">The emblem color.</param>
        [JsonConstructor]
        public GuildCrestEmblemWithColor(int id, Media media, Color color)
        {
            Id = id;
            Media = media;
            Color = color;
        }
    }
}
