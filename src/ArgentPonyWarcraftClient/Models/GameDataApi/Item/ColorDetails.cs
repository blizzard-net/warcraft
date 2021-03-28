using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// RGBA color information.
    /// </summary>
    public record ColorDetails
    {
        /// <summary>
        /// Gets the red channel value for the color.
        /// </summary>
        [JsonPropertyName("r")]
        public int Red { get; }

        /// <summary>
        /// Gets the green channel value for the color.
        /// </summary>
        [JsonPropertyName("g")]
        public int Green { get; }

        /// <summary>
        /// Gets the blue channel value for the color.
        /// </summary>
        [JsonPropertyName("b")]
        public int Blue { get; }

        /// <summary>
        /// Gets the alpha (opacity) channel value for the color.
        /// </summary>
        [JsonPropertyName("a")]
        public float Alpha { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorDetails"/> class.
        /// </summary>
        /// <param name="red">The red channel value for the color.</param>
        /// <param name="green">The green channel value for the color.</param>
        /// <param name="blue">The blue channel value for the color.</param>
        /// <param name="alpha">The alpha (opacity) channel value for the color.</param>
        [JsonConstructor]
        public ColorDetails(int red, int green, int blue, float alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
    }
}
