using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A value with an associated display string.
    /// </summary>
    public class DescribedValue
    {
        /// <summary>
        /// Gets the numerical value.
        /// </summary>
        [JsonPropertyName("value")]
        public float Value { get; set; }

        /// <summary>
        /// Gets a display string for the value.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }
    }
}
