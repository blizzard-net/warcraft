using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement aggregates for a faction.
    /// </summary>
    public record FactionAchievementAggregates
    {
        /// <summary>
        /// Gets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; }

        /// <summary>
        /// Gets the number of points.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactionAchievementAggregates"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="points">The number of points.</param>
        [JsonConstructor]
        public FactionAchievementAggregates(int quantity, int points)
        {
            Quantity = quantity;
            Points = points;
        }
    }
}
