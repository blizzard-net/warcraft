using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A position in the game.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Gets the zone.
        /// </summary>
        [JsonPropertyName("zone")]
        public Map Zone { get; set; }

        /// <summary>
        /// Gets the map.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the x coordinate.
        /// </summary>
        [JsonPropertyName("x")]
        public float X { get; set; }

        /// <summary>
        /// Gets the y coordinate.
        /// </summary>
        [JsonPropertyName("y")]
        public float Y { get; set; }

        /// <summary>
        /// Gets the z coordinate.
        /// </summary>
        [JsonPropertyName("z")]
        public float Z { get; set; }

        /// <summary>
        /// Gets the facing.
        /// </summary>
        [JsonPropertyName("facing")]
        public float Facing { get; set; }
    }
}
