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
        public double X { get; set; }

        /// <summary>
        /// Gets the y coordinate.
        /// </summary>
        [JsonPropertyName("y")]
        public double Y { get; set; }

        /// <summary>
        /// Gets the z coordinate.
        /// </summary>
        [JsonPropertyName("z")]
        public double Z { get; set; }

        /// <summary>
        /// Gets the facing.
        /// </summary>
        [JsonPropertyName("facing")]
        public double Facing { get; set; }
    }
}
