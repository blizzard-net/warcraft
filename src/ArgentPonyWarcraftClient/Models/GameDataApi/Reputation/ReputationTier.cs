using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation tier.
    /// </summary>
    public class ReputationTier
    {
        /// <summary>
        /// Gets the name of the reputation tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum value of the reputation tier.
        /// </summary>
        [JsonProperty("min_value")]
        public long MinValue { get; set; }

        /// <summary>
        /// Gets the maximum value of the reputation tier.
        /// </summary>
        [JsonProperty("max_value")]
        public long MaxValue { get; set; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
