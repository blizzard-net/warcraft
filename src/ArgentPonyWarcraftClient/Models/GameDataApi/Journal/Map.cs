using Newtonsoft.Json;

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
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the map.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
