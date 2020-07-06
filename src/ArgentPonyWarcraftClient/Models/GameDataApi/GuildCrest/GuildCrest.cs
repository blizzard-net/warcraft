using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest.
    /// </summary>
    public class GuildCrest
    {
        /// <summary>
        /// Gets the guild crest emblem and color.
        /// </summary>
        [JsonProperty("emblem")]
        public GuildCrestEmblemWithColor Emblem { get; set; }

        /// <summary>
        /// Gets the guild crest border and color.
        /// </summary>
        [JsonProperty("border")]
        public GuildCrestBorderWithColor Border { get; set; }

        /// <summary>
        /// Gets the guild crest background.
        /// </summary>
        [JsonProperty("background")]
        public Background Background { get; set; }
    }
}
