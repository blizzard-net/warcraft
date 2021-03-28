using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Display details for a stat modifier.
    /// </summary>
    public record StatDisplay
    {
        /// <summary>
        /// Gets the display string for the stat.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the color associated with the stat.
        /// </summary>
        [JsonPropertyName("color")]
        public ColorDetails Color { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatDisplay"/> class.
        /// </summary>
        /// <param name="displayString">The display string for the stat.</param>
        /// <param name="color">The color associated with the stat.</param>
        [JsonConstructor]
        public StatDisplay(string displayString, ColorDetails color)
        {
            DisplayString = displayString;
            Color = color;
        }
    }
}
