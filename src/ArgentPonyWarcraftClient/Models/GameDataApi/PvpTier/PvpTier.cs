using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP tier.
    /// </summary>
    public class PvpTier
    {
        /// <summary>
        /// Gets links for the PvP tier.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the PvP tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum rating for the PvP tier.
        /// </summary>
        [JsonPropertyName("min_rating")]
        public long MinRating { get; set; }

        /// <summary>
        /// Gets the maximum rating for the PvP tier.
        /// </summary>
        [JsonPropertyName("max_rating")]
        public long MaxRating { get; set; }

        /// <summary>
        /// Gets the media associated with the PvP tier.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the bracket for the PvP tier.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets the rating type for the PvP tier.
        /// </summary>
        [JsonPropertyName("rating_type")]
        public long RatingType { get; set; }
    }
}
