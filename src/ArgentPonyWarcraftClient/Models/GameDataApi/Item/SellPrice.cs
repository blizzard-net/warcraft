using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A sell price.
    /// </summary>
    public record SellPrice
    {
        /// <summary>
        /// Gets the numeric value of the sell price.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; }

        /// <summary>
        /// Gets the currency display information for the sell price.
        /// </summary>
        [JsonPropertyName("display_strings")]
        public CurrencyDisplay DisplayStrings { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SellPrice"/> class.
        /// </summary>
        /// <param name="value">The numeric value of the sell price.</param>
        /// <param name="displayStrings">The currency display information for the sell price.</param>
        [JsonConstructor]
        public SellPrice(long value, CurrencyDisplay displayStrings)
        {
            Value = value;
            DisplayStrings = displayStrings;
        }
    }
}
