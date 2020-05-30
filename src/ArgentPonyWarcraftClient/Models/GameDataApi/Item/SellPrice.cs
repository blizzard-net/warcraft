using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A sell price.
    /// </summary>
    public class SellPrice
    {
        /// <summary>
        /// Gets the numeric value of the sell price.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the currency display information for the sell price.
        /// </summary>
        [JsonProperty("display_strings")]
        public CurrencyDisplay DisplayStrings { get; set; }
    }
}
