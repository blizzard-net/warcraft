using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A difficulty mode of a dungeon or raid instance.
    /// </summary>
    public class InstanceMode
    {
        /// <summary>
        /// Gets the difficulty mode.
        /// </summary>
        [JsonProperty("mode")]
        public EnumType Mode { get; set; }

        /// <summary>
        /// Gets the number of players.
        /// </summary>
        [JsonProperty("players")]
        public long Players { get; set; }

        /// <summary>
        /// Gets a value indicating whether this difficulty mode is tracked.
        /// </summary>
        [JsonProperty("is_tracked")]
        public bool IsTracked { get; set; }
    }
}
