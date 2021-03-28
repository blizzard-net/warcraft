using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Currency display strings for a price.
    /// </summary>
    public record CurrencyDisplay
    {
        /// <summary>
        /// Gets the header.
        /// </summary>
        [JsonPropertyName("header")]
        public string Header { get; }

        /// <summary>
        /// Gets the gold portion of the price.
        /// </summary>
        [JsonPropertyName("gold")]
        public string Gold { get; }

        /// <summary>
        /// Gets the silver portion of the price.
        /// </summary>
        [JsonPropertyName("silver")]
        public string Silver { get; }

        /// <summary>
        /// Gets the copper portion of the price.
        /// </summary>
        [JsonPropertyName("copper")]
        public string Copper { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDisplay"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="gold">The gold portion of the price.</param>
        /// <param name="silver">The silver portion of the price.</param>
        /// <param name="copper">The copper portion of the price.</param>
        [JsonConstructor]
        public CurrencyDisplay(string header, string gold, string silver, string copper)
        {
            Header = header;
            Gold = gold;
            Silver = silver;
            Copper = copper;
        }
    }
}
