using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable class.
    /// </summary>
    public class PlayableClassReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the playable class.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
