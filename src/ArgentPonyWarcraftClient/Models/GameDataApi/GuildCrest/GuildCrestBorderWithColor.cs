using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest border with color.
    /// </summary>
    public class GuildCrestBorderWithColor
    {
        /// <summary>
        /// Gets the ID of the border.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the border.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the border color.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }
    }
}
