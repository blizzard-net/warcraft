using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A monetary amount as gold, silver, and copper units.
    /// </summary>
    public class Units
    {
        /// <summary>
        /// Gets the amount of gold.
        /// </summary>
        [JsonPropertyName("gold")]
        public long Gold { get; set; }

        /// <summary>
        /// Gets the amount of silver.
        /// </summary>
        [JsonPropertyName("silver")]
        public int Silver { get; set; }

        /// <summary>
        /// Gets the amount of copper.
        /// </summary>
        [JsonPropertyName("copper")]
        public int Copper { get; set; }
    }
}
