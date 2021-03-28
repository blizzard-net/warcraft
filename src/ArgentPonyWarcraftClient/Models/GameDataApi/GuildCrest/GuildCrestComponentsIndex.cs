using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of guild crest media.
    /// </summary>
    public record GuildCrestComponentsIndex
    {
        /// <summary>
        /// Gets links for the index of guild crest media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the guild crest emblems.
        /// </summary>
        [JsonPropertyName("emblems")]
        public GuildCrestEmblem[] Emblems { get; }

        /// <summary>
        /// Gets the guild crest borders.
        /// </summary>
        [JsonPropertyName("borders")]
        public GuildCrestBorder[] Borders { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuildCrestComponentsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of guild crest media.</param>
        /// <param name="emblems">The guild crest emblems.</param>
        /// <param name="borders">The guild crest borders.</param>
        [JsonConstructor]
        public GuildCrestComponentsIndex(Links links, GuildCrestEmblem[] emblems, GuildCrestBorder[] borders)
        {
            Links = links;
            Emblems = emblems;
            Borders = borders;
        }
    }
}
