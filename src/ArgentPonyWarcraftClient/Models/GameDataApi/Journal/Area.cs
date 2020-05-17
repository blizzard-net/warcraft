using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An area.
    /// </summary>
    public class Area
    {
        /// <summary>
        /// Gets the name of the area.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the area.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
