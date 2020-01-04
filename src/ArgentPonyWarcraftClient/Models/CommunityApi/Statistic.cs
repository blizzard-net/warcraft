using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A statistic.
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// Gets or sets the statistic ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the statistic name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp.
        /// </summary>
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets a money indicator.
        /// </summary>
        [JsonProperty("money")]
        public bool Money { get; set; }

        /// <summary>
        /// Gets or sets the highest.
        /// </summary>
        [JsonProperty("highest")]
        public string Highest { get; set; }
    }
}
