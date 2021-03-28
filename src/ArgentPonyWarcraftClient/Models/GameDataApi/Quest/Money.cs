using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A monetary amount.
    /// </summary>
    public record Money
    {
        /// <summary>
        /// Gets the numerical value of the money.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; }

        /// <summary>
        /// Gets the monetary amount as gold, silver, and copper units.
        /// </summary>
        [JsonPropertyName("units")]
        public Units Units { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        /// <param name="value">The numerical value of the money.</param>
        /// <param name="units">The monetary amount as gold, silver, and copper units.</param>
        [JsonConstructor]
        public Money(long value, Units units)
        {
            Value = value;
            Units = units;
        }
    }
}
