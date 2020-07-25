using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic with a rating.
    /// </summary>
    public class RatingStatisticWithoutValue
    {
        /// <summary>
        /// Gets the rating.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets the rating bonus.
        /// </summary>
        [JsonPropertyName("rating_bonus")]
        public float RatingBonus { get; set; }
    }
}
