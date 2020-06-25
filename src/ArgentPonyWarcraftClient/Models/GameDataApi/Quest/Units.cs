using Newtonsoft.Json;

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
        [JsonProperty("gold")]
        public long Gold { get; set; }

        /// <summary>
        /// Gets the amount of silver.
        /// </summary>
        [JsonProperty("silver")]
        public long Silver { get; set; }

        /// <summary>
        /// Gets the amount of copper.
        /// </summary>
        [JsonProperty("copper")]
        public long Copper { get; set; }
    }
}
