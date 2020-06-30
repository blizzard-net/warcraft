using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the PvP tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the minimum rating for the PvP tier.
        /// </summary>
        [JsonProperty("min_rating")]
        public long MinRating { get; set; }

        /// <summary>
        /// Gets the maximum rating for the PvP tier.
        /// </summary>
        [JsonProperty("max_rating")]
        public long MaxRating { get; set; }

        /// <summary>
        /// Gets the media associated with the PvP tier.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the bracket for the PvP tier.
        /// </summary>
        [JsonProperty("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets the rating type for the PvP tier.
        /// </summary>
        [JsonProperty("rating_type")]
        public long RatingType { get; set; }
    }
}
