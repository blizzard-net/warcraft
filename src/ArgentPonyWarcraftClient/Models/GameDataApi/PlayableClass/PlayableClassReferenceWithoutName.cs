using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
