using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A sell price.
    /// </summary>
    public class SellPrice
    {
        /// <summary>
        /// Gets the numeric value of the sell price.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the currency display information for the sell price.
        /// </summary>
        [JsonPropertyName("display_strings")]
        public CurrencyDisplay DisplayStrings { get; set; }
    }
}
