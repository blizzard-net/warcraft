using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic with a rating.
    /// </summary>
    public record RatingStatistic
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
        /// Gets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public float Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatingStatistic"/> class.
        /// </summary>
        /// <param name="rating">The rating.</param>
        /// <param name="ratingBonus">The rating bonus.</param>
        /// <param name="value">The value.</param>
        [JsonConstructor]
        public RatingStatistic(int rating, float ratingBonus, float value)
        {
            Rating = rating;
            RatingBonus = ratingBonus;
            Value = value;
        }
    }
}
