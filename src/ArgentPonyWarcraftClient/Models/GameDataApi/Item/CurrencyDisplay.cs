using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Currency display strings for a price.
    /// </summary>
    public class CurrencyDisplay
    {
        /// <summary>
        /// Gets the header.
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }

        /// <summary>
        /// Gets the gold portion of the price.
        /// </summary>
        [JsonProperty("gold")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gold { get; set; }

        /// <summary>
        /// Gets the silver portion of the price.
        /// </summary>
        [JsonProperty("silver")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Silver { get; set; }

        /// <summary>
        /// Gets the copper portion of the price.
        /// </summary>
        [JsonProperty("copper")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Copper { get; set; }
    }
}
