using System.Text.Json.Serialization;

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
        [JsonPropertyName("mode")]
        public EnumType Mode { get; set; }

        /// <summary>
        /// Gets the number of players.
        /// </summary>
        [JsonPropertyName("players")]
        public int Players { get; set; }

        /// <summary>
        /// Gets a value indicating whether this difficulty mode is tracked.
        /// </summary>
        [JsonPropertyName("is_tracked")]
        public bool IsTracked { get; set; }
    }
}
