using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest emblem.
    /// </summary>
    public record GuildCrestEmblem
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
        /// Initializes a new instance of the <see cref="GuildCrestEmblem"/> class.
        /// </summary>
        /// <param name="id">The ID of the emblem.</param>
        /// <param name="media">The media associated with the emblem.</param>
        [JsonConstructor]
        public GuildCrestEmblem(int id, Media media)
        {
            Id = id;
            Media = media;
        }
    }
}
