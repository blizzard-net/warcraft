using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A background.
    /// </summary>
    public class Background
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }
    }
}
