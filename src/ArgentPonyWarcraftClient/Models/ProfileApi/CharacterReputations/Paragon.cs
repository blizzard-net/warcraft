using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's paragon status with a reputation faction.
    /// </summary>
    public class Paragon
    {
        /// <summary>
        /// Gets the raw number.
        /// </summary>
        [JsonPropertyName("raw")]
        public long Raw { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonPropertyName("max")]
        public long Max { get; set; }
    }
}
