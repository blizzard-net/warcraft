using System.Text.Json.Serialization;

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
        [JsonPropertyName("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// Gets the rating bonus.
        /// </summary>
        [JsonPropertyName("rating_bonus")]
        public double RatingBonus { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
