using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement aggregates for a faction.
    /// </summary>
    public class FactionAchievementAggregates
    {
        /// <summary>
        /// Gets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets the number of points.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; set; }
    }
}
