using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the guild crest emblems.
        /// </summary>
        [JsonProperty("emblems")]
        public GuildCrestEmblem[] Emblems { get; set; }

        /// <summary>
        /// Gets the guild crest borders.
        /// </summary>
        [JsonProperty("borders")]
        public GuildCrestBorder[] Borders { get; set; }
    }
}
