using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A difficulty mode of a dungeon or raid instance.
    /// </summary>
    public record InstanceMode
    {
        /// <summary>
        /// Gets the difficulty mode.
        /// </summary>
        [JsonPropertyName("mode")]
        public EnumType Mode { get; }

        /// <summary>
        /// Gets the number of players.
        /// </summary>
        [JsonPropertyName("players")]
        public int Players { get; }

        /// <summary>
        /// Gets a value indicating whether this difficulty mode is tracked.
        /// </summary>
        [JsonPropertyName("is_tracked")]
        public bool IsTracked { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceMode"/> class.
        /// </summary>
        /// <param name="mode">The difficulty mode.</param>
        /// <param name="players">The number of players.</param>
        /// <param name="isTracked">A value indicating whether this difficulty mode is tracked.</param>
        [JsonConstructor]
        public InstanceMode(EnumType mode, int players, bool isTracked)
        {
            Mode = mode;
            Players = players;
            IsTracked = isTracked;
        }
    }
}
