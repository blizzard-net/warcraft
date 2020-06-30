using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character achievement statistic.
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// Gets the ID of the statistic.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the statistic.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the timestamp when the statistic was last updated.
        /// </summary>
        [JsonProperty("last_updated_timestamp")]
        public DateTime LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets a quantity associated with the statistic.
        /// </summary>
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets an optional description of the statistic.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
