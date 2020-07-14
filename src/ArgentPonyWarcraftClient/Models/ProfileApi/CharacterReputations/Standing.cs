using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's standing with a reputation faction.
    /// </summary>
    public class Standing
    {
        /// <summary>
        /// Gets the raw number.
        /// </summary>
        [JsonProperty("raw")]
        public long Raw { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonProperty("max")]
        public long Max { get; set; }

        /// <summary>
        /// Gets the reputation tier.
        /// </summary>
        [JsonProperty("tier")]
        public long Tier { get; set; }

        /// <summary>
        /// Gets the name of the standing.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
