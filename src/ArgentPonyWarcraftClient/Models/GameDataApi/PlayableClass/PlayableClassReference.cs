using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the playable class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the playable class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
