using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the location.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
