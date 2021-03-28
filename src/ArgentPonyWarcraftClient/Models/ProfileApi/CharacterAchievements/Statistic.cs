using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character achievement statistic.
    /// </summary>
    public record Statistic
    {
        /// <summary>
        /// Gets the ID of the statistic.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the statistic.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the timestamp when the statistic was last updated.
        /// </summary>
        [JsonPropertyName("last_updated_timestamp")]
        public DateTimeOffset LastUpdatedTimestamp { get; }

        /// <summary>
        /// Gets a quantity associated with the statistic.
        /// </summary>
        [JsonPropertyName("quantity")]
        public float Quantity { get; }

        /// <summary>
        /// Gets an optional description of the statistic.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Statistic"/> class.
        /// </summary>
        /// <param name="id">The ID of the statistic.</param>
        /// <param name="name">The name of the statistic.</param>
        /// <param name="lastUpdatedTimestamp">The timestamp when the statistic was last updated.</param>
        /// <param name="quantity">A quantity associated with the statistic.</param>
        /// <param name="description">An optional description of the statistic.</param>
        [JsonConstructor]
        public Statistic(int id, string name, DateTimeOffset lastUpdatedTimestamp, float quantity, string description)
        {
            Id = id;
            Name = name;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            Quantity = quantity;
            Description = description;
        }
    }
}
