using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's standing with a reputation faction.
    /// </summary>
    public record Standing
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
        /// Gets the reputation tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; }

        /// <summary>
        /// Gets the name of the standing.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Standing"/> class.
        /// </summary>
        /// <param name="raw">The raw number.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="tier">The reputation tier.</param>
        /// <param name="name">The name of the standing.</param>
        [JsonConstructor]
        public Standing(int raw, int value, int max, int tier, string name)
        {
            Raw = raw;
            Value = value;
            Max = max;
            Tier = tier;
            Name = name;
        }
    }
}
