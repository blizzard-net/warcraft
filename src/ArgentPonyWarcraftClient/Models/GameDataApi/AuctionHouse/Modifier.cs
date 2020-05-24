using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An item modifier.
    /// </summary>
    public class Modifier
    {
        /// <summary>
        /// Gets the type of modifier.
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }

        /// <summary>
        /// Gets the value of the modifier.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
