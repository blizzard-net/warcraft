using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic with a rating.
    /// </summary>
    public class RatingStatistic
    {
        /// <summary>
        /// Gets the rating.
        /// </summary>
        [JsonProperty("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// Gets the rating bonus.
        /// </summary>
        [JsonProperty("rating_bonus")]
        public double RatingBonus { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
