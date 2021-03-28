using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic with a rating.
    /// </summary>
    public record RatingStatisticWithoutValue
    {
        /// <summary>
        /// Gets the rating.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; }

        /// <summary>
        /// Gets the rating bonus.
        /// </summary>
        [JsonPropertyName("rating_bonus")]
        public float RatingBonus { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatingStatisticWithoutValue"/> class.
        /// </summary>
        /// <param name="rating">The rating.</param>
        /// <param name="ratingBonus">The rating bonus.</param>
        [JsonConstructor]
        public RatingStatisticWithoutValue(int rating, float ratingBonus)
        {
            Rating = rating;
            RatingBonus = ratingBonus;
        }
    }
}
