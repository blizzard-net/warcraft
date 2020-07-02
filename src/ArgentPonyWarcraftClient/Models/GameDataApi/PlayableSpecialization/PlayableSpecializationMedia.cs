using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
