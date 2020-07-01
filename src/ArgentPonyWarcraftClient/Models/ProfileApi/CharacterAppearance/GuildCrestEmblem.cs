using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the emblem.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the emblem color.
        /// </summary>
        [JsonProperty("color")]
        public Color Color { get; set; }
    }
}
