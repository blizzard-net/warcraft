using Newtonsoft.Json;

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
        [JsonProperty("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// Gets the rating bonus.
        /// </summary>
        [JsonProperty("rating_bonus")]
        public long RatingBonus { get; set; }
    }
}
