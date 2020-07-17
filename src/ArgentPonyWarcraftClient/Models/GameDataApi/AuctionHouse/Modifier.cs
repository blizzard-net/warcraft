using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item modifier.
    /// </summary>
    public class Modifier
    {
        /// <summary>
        /// Gets the type of modifier.
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }

        /// <summary>
        /// Gets the value of the modifier.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
