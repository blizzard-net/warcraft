using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild crest.
    /// </summary>
    public record GuildCrest
    {
        /// <summary>
        /// Gets the guild crest emblem and color.
        /// </summary>
        [JsonPropertyName("emblem")]
        public GuildCrestEmblemWithColor Emblem { get; }

        /// <summary>
        /// Gets the guild crest border and color.
        /// </summary>
        [JsonPropertyName("border")]
        public GuildCrestBorderWithColor Border { get; }

        /// <summary>
        /// Gets the guild crest background.
        /// </summary>
        [JsonPropertyName("background")]
        public Background Background { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrest"/> class.
        /// </summary>
        /// <param name="emblem">The guild crest emblem and color.</param>
        /// <param name="border">The guild crest border and color.</param>
        /// <param name="background">The guild crest background.</param>
        [JsonConstructor]
        public GuildCrest(GuildCrestEmblemWithColor emblem, GuildCrestBorderWithColor border, Background background)
        {
            Emblem = emblem;
            Border = border;
            Background = background;
        }
    }
}
