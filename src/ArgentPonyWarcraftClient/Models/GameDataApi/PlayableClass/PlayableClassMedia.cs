using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
