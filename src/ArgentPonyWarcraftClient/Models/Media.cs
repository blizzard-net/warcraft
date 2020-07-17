using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the ID of the media.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; private set; }
    }
}
