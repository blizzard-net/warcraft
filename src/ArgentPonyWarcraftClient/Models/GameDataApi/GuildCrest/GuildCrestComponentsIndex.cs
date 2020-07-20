using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of guild crest media.
    /// </summary>
    public class GuildCrestComponentsIndex
    {
        /// <summary>
        /// Gets links for the index of guild crest media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the guild crest emblems.
        /// </summary>
        [JsonPropertyName("emblems")]
        public GuildCrestEmblem[] Emblems { get; set; }

        /// <summary>
        /// Gets the guild crest borders.
        /// </summary>
        [JsonPropertyName("borders")]
        public GuildCrestBorder[] Borders { get; set; }
    }
}
