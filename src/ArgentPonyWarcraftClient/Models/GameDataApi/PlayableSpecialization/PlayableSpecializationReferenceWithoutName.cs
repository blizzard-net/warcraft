using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable specialization.
    /// </summary>
    public class PlayableSpecializationReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the playable specialization.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the playable specialization.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
