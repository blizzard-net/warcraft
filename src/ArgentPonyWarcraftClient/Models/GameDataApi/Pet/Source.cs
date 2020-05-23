using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A source for a pet.
    /// </summary>
    public class Source
    {
        /// <summary>
        /// Gets the type of the pet source.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the name of the pet source.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
