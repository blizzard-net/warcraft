using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest border.
    /// </summary>
    public class GuildCrestBorder
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
    }
}
