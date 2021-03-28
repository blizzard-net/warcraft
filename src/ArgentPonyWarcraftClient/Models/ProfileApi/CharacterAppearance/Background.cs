using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A background.
    /// </summary>
    public record Background
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Background"/> class.
        /// </summary>
        /// <param name="color">The background color.</param>
        [JsonConstructor]
        public Background(Color color)
        {
            Color = color;
        }
    }
}
