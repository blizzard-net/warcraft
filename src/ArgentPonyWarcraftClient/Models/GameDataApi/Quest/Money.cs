using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A monetary amount.
    /// </summary>
    public class Money
    {
        /// <summary>
        /// Gets the numerical value of the money.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the monetary amount as gold, silver, and copper units.
        /// </summary>
        [JsonPropertyName("units")]
        public Units Units { get; set; }
    }
}
