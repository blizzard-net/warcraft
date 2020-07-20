using System.Text.Json.Serialization;

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
        [JsonPropertyName("emblem")]
        public GuildCrestEmblemWithColor Emblem { get; set; }

        /// <summary>
        /// Gets the guild crest border and color.
        /// </summary>
        [JsonPropertyName("border")]
        public GuildCrestBorderWithColor Border { get; set; }

        /// <summary>
        /// Gets the guild crest background.
        /// </summary>
        [JsonPropertyName("background")]
        public Background Background { get; set; }
    }
}
