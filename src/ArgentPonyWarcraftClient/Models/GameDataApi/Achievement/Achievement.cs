using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An achievement.
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// Gets links for this achievement.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a reference to the achievement category to which this achievement belongs.
        /// </summary>
        [JsonPropertyName("category")]
        public AchievementCategoryReference Category { get; set; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of this achievement.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the number of achievement points associated with this achievement.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; set; }

        /// <summary>
        /// Gets a value indicating whether this achievement is account-wide.
        /// </summary>
        [JsonPropertyName("is_account_wide")]
        public bool IsAccountWide { get; set; }

        /// <summary>
        /// Gets the criteria for this achievement.
        /// </summary>
        [JsonPropertyName("criteria")]
        public AchievementCriteria Criteria { get; set; }

        /// <summary>
        /// Gets a reference to the next achievement.
        /// </summary>
        [JsonPropertyName("next_achievement")]
        public AchievementReference NextAchievement { get; set; }

        /// <summary>
        /// Gets the media associated with this achievement.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; set; }
    }
}
