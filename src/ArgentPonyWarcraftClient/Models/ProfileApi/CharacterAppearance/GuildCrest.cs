using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest.
    /// </summary>
    public class GuildCrest
    {
        /// <summary>
        /// Gets the guild crest emblem.
        /// </summary>
        [JsonProperty("emblem")]
        public GuildCrestEmblem Emblem { get; set; }

        /// <summary>
        /// Gets the guild crest border.
        /// </summary>
        [JsonProperty("border")]
        public GuildCrestBorder Border { get; set; }

        /// <summary>
        /// Gets the guild crest background.
        /// </summary>
        [JsonProperty("background")]
        public Background Background { get; set; }
    }
}
