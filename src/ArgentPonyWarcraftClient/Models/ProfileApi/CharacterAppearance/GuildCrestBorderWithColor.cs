using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the border.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the border color.
        /// </summary>
        [JsonProperty("color")]
        public Color Color { get; set; }
    }
}
