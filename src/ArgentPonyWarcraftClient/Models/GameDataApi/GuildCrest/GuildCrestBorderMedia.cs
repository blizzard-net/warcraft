using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a guild crest border.
    /// </summary>
    public class GuildCrestBorderMedia
    {
        /// <summary>
        /// Gets links for the guild crest border media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the guild crest border.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
