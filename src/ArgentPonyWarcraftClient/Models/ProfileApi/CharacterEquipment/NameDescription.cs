using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Gets a name description modifier for an item.
    /// </summary>
    public record NameDescription
    {
        /// <summary>
        /// Gets the display string for the 
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the RGBA color information.
        /// </summary>
        [JsonPropertyName("color")]
        public ColorDetails Color { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameDescription"/> class.
        /// </summary>
        /// <param name="displayString">The display string for the </param>
        /// <param name="color">The RGBA color information.</param>
        [JsonConstructor]
        public NameDescription(string displayString, ColorDetails color)
        {
            DisplayString = displayString;
            Color = color;
        }
    }
}
