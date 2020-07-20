using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the guild crest border.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
