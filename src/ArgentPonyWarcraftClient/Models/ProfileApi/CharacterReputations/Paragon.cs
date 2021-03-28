using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's paragon status with a reputation faction.
    /// </summary>
    public record Paragon
    {
        /// <summary>
        /// Gets the raw number.
        /// </summary>
        [JsonPropertyName("raw")]
        public int Raw { get; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonPropertyName("max")]
        public int Max { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Paragon"/> class.
        /// </summary>
        /// <param name="raw">The raw number.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum value.</param>
        [JsonConstructor]
        public Paragon(int raw, int value, int max)
        {
            Raw = raw;
            Value = value;
            Max = max;
        }
    }
}
