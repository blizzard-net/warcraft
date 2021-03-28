using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP tier.
    /// </summary>
    public record PvpTier
    {
        /// <summary>
        /// Gets links for the PvP tier.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the PvP tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the minimum rating for the PvP tier.
        /// </summary>
        [JsonPropertyName("min_rating")]
        public int MinRating { get; }

        /// <summary>
        /// Gets the maximum rating for the PvP tier.
        /// </summary>
        [JsonPropertyName("max_rating")]
        public int MaxRating { get; }

        /// <summary>
        /// Gets the media associated with the PvP tier.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets the bracket for the PvP tier.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; }

        /// <summary>
        /// Gets the rating type for the PvP tier.
        /// </summary>
        [JsonPropertyName("rating_type")]
        public int RatingType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTier"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP tier.</param>
        /// <param name="id">The ID of the PvP tier.</param>
        /// <param name="name">The name of the PvP tier.</param>
        /// <param name="minRating">The minimum rating for the PvP tier.</param>
        /// <param name="maxRating">The maximum rating for the PvP tier.</param>
        /// <param name="media">The media associated with the PvP tier.</param>
        /// <param name="bracket">The bracket for the PvP tier.</param>
        /// <param name="ratingType">The rating type for the PvP tier.</param>
        [JsonConstructor]
        public PvpTier(Links links, int id, string name, int minRating, int maxRating, Media media, Bracket bracket, int ratingType)
        {
            Links = links;
            Id = id;
            Name = name;
            MinRating = minRating;
            MaxRating = maxRating;
            Media = media;
            Bracket = bracket;
            RatingType = ratingType;
        }
    }
}
