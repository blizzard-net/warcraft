using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a playable race.
    /// </summary>
    public class PlayableRaceReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the playable race.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
