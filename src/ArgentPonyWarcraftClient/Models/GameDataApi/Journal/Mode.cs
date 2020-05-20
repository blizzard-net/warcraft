using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// The difficulty mode of the dungeon or raid.
    /// </summary>
    public class Mode
    {
        /// <summary>
        /// Gets the type of the difficulty mode.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the name of the difficulty mode.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
