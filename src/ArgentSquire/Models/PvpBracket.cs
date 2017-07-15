using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A PvP bracket.
    /// </summary>
    public class PvpBracket
    {
        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the weekly number played.
        /// </summary>
        [JsonProperty("weeklyPlayed")]
        public int WeeklyPlayed { get; set; }

        /// <summary>
        /// Gets or sets the weekly number won.
        /// </summary>
        [JsonProperty("weeklyWon")]
        public int WeeklyWon { get; set; }

        /// <summary>
        /// Gets or sets the weekly number lost.
        /// </summary>
        [JsonProperty("weeklyLost")]
        public int WeeklyLost { get; set; }

        /// <summary>
        /// Gets or sets the season played.
        /// </summary>
        [JsonProperty("seasonPlayed")]
        public int SeasonPlayed { get; set; }

        /// <summary>
        /// Gets or sets the season won.
        /// </summary>
        [JsonProperty("seasonWon")]
        public int SeasonWon { get; set; }

        /// <summary>
        /// Gets or sets the season lost.
        /// </summary>
        [JsonProperty("seasonLost")]
        public int SeasonLost { get; set; }
    }
}
