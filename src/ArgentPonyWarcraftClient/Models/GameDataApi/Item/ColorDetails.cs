using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// RGBA color information.
    /// </summary>
    public class ColorDetails
    {
        /// <summary>
        /// Gets the red channel value for the color.
        /// </summary>
        [JsonPropertyName("r")]
        public int Red { get; set; }

        /// <summary>
        /// Gets the green channel value for the color.
        /// </summary>
        [JsonPropertyName("g")]
        public int Green { get; set; }

        /// <summary>
        /// Gets the blue channel value for the color.
        /// </summary>
        [JsonPropertyName("b")]
        public int Blue { get; set; }

        /// <summary>
        /// Gets the alpha (opacity) channel value for the color.
        /// </summary>
        [JsonPropertyName("a")]
        public int Alpha { get; set; }
    }
}
