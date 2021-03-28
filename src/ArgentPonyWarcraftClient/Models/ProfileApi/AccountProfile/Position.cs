using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A position in the game.
    /// </summary>
    public record Position
    {
        /// <summary>
        /// Gets the zone.
        /// </summary>
        [JsonPropertyName("zone")]
        public Map Zone { get; }

        /// <summary>
        /// Gets the map.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; }

        /// <summary>
        /// Gets the x coordinate.
        /// </summary>
        [JsonPropertyName("x")]
        public float X { get; }

        /// <summary>
        /// Gets the y coordinate.
        /// </summary>
        [JsonPropertyName("y")]
        public float Y { get; }

        /// <summary>
        /// Gets the z coordinate.
        /// </summary>
        [JsonPropertyName("z")]
        public float Z { get; }

        /// <summary>
        /// Gets the facing.
        /// </summary>
        [JsonPropertyName("facing")]
        public float Facing { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="zone">The zone.</param>
        /// <param name="map">The map.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="z">The z coordinate.</param>
        /// <param name="facing">The facing.</param>
        [JsonConstructor]
        public Position(Map zone, Map map, float x, float y, float z, float facing)
        {
            Zone = zone;
            Map = map;
            X = x;
            Y = y;
            Z = z;
            Facing = facing;
        }
    }
}
