using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest emblem.
    /// </summary>
    public class GuildCrestEmblem
    {
        /// <summary>
        /// Gets the ID of the emblem.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the emblem.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
