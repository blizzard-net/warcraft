using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A value with an associated display string.
    /// </summary>
    public record DescribedValue
    {
        /// <summary>
        /// Gets the numerical value.
        /// </summary>
        [JsonPropertyName("value")]
        public float Value { get; }

        /// <summary>
        /// Gets a display string for the value.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribedValue"/> class.
        /// </summary>
        /// <param name="value">The numerical value.</param>
        /// <param name="displayString">A display string for the value.</param>
        [JsonConstructor]
        public DescribedValue(float value, string displayString)
        {
            Value = value;
            DisplayString = displayString;
        }
    }
}
