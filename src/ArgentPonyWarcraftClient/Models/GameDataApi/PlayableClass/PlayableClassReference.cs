using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable class.
    /// </summary>
    public class PlayableClassReference
    {
        /// <summary>
        /// Gets the key for the playable class.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
