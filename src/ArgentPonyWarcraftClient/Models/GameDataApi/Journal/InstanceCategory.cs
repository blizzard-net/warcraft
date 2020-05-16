using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// The category of the instance (i.e., "DUNGEON" or "RAID").
    /// </summary>
    public class InstanceCategory
    {
        /// <summary>
        /// Gets the type of the instance category.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
