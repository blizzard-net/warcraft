using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A map.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets the name of the map.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the map.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
