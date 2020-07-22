using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A color.
    /// </summary>
    public class Color
    {
        /// <summary>
        /// Gets the ID of the color.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the RGBA color information.
        /// </summary>
        [JsonPropertyName("rgba")]
        public ColorDetails Rgba { get; set; }
    }
}
