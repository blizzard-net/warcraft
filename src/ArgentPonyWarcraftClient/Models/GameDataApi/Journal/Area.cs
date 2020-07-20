using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An area.
    /// </summary>
    public class Area
    {
        /// <summary>
        /// Gets the name of the area.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the area.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
