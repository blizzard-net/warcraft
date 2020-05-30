using Newtonsoft.Json;

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
        [JsonProperty("quantity")]
        public int Quantity { get; private set; }

        /// <summary>
        /// Gets the number of points.
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; private set; }
    }
}
