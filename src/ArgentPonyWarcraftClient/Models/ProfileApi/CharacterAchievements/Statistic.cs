using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the statistic.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the timestamp when the statistic was last updated.
        /// </summary>
        [JsonPropertyName("last_updated_timestamp")]
        public DateTimeOffset LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets a quantity associated with the statistic.
        /// </summary>
        [JsonPropertyName("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets an optional description of the statistic.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
