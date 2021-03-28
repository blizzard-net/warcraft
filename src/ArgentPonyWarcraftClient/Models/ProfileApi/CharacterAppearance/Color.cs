using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A color.
    /// </summary>
    public record Color
    {
        /// <summary>
        /// Gets the ID of the color.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the RGBA color information.
        /// </summary>
        [JsonPropertyName("rgba")]
        public ColorDetails Rgba { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class.
        /// </summary>
        /// <param name="id">The ID of the color.</param>
        /// <param name="rgba">The RGBA color information.</param>
        [JsonConstructor]
        public Color(int id, ColorDetails rgba)
        {
            Id = id;
            Rgba = rgba;
        }
    }
}
