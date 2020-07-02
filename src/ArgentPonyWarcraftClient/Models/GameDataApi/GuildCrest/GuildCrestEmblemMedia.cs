using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a guild crest emblem.
    /// </summary>
    public class GuildCrestEmblemMedia
    {
        /// <summary>
        /// Gets links for the guild crest emblem media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the guild crest emblem.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
