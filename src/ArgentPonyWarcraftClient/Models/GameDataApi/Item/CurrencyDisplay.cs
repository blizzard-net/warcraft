using System.Text.Json.Serialization;

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
        [JsonPropertyName("header")]
        public string Header { get; set; }

        /// <summary>
        /// Gets the gold portion of the price.
        /// </summary>
        [JsonPropertyName("gold")]
        public string Gold { get; set; }

        /// <summary>
        /// Gets the silver portion of the price.
        /// </summary>
        [JsonPropertyName("silver")]
        public string Silver { get; set; }

        /// <summary>
        /// Gets the copper portion of the price.
        /// </summary>
        [JsonPropertyName("copper")]
        public string Copper { get; set; }
    }
}
