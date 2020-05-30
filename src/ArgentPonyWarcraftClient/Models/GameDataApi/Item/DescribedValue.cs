using Newtonsoft.Json;

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
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// Gets a display string for the value.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }
    }
}
