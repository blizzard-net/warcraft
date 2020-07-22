using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the playable race.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
