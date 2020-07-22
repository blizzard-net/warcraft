using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Playable class media.
    /// </summary>
    public class PlayableClassMedia
    {
        /// <summary>
        /// Gets links for the playable class media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
