using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the guild crest emblem.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
