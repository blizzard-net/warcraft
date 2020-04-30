using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A media reference.
    /// </summary>
    public class Media
    {
        /// <summary>
        /// Gets the key for the media.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the ID of the media.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
    }
}
