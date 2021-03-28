using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item modifier.
    /// </summary>
    public record Modifier
    {
        /// <summary>
        /// Gets the type of modifier.
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; }

        /// <summary>
        /// Gets the value of the modifier.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Modifier"/> class.
        /// </summary>
        /// <param name="type">The type of modifier.</param>
        /// <param name="value">The value of the modifier.</param>
        [JsonConstructor]
        public Modifier(int type, int value)
        {
            Type = type;
            Value = value;
        }
    }
}
