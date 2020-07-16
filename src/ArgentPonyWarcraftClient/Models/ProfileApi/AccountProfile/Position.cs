using Newtonsoft.Json;

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
        [JsonProperty("zone")]
        public Map Zone { get; set; }

        /// <summary>
        /// Gets the map.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the x coordinate.
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// Gets the y coordinate.
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        /// <summary>
        /// Gets the z coordinate.
        /// </summary>
        [JsonProperty("z")]
        public double Z { get; set; }

        /// <summary>
        /// Gets the facing.
        /// </summary>
        [JsonProperty("facing")]
        public double Facing { get; set; }
    }
}
