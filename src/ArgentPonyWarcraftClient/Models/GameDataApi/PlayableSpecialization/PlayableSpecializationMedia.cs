using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Playable specialization media.
    /// </summary>
    public class PlayableSpecializationMedia
    {
        /// <summary>
        /// Gets links for the playable specialization media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
