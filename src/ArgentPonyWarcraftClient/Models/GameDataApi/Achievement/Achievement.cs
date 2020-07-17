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
        public Links Links { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; private set; }

        /// <summary>
        /// Gets a reference to the achievement category to which this achievement belongs.
        /// </summary>
        [JsonPropertyName("category")]
        public AchievementCategoryReference Category { get; private set; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description of this achievement.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the number of achievement points associated with this achievement.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this achievement is account-wide.
        /// </summary>
        [JsonPropertyName("is_account_wide")]
        public bool IsAccountWide { get; private set; }

        /// <summary>
        /// Gets the criteria for this achievement.
        /// </summary>
        [JsonPropertyName("criteria")]
        public AchievementCriteria Criteria { get; private set; }

        /// <summary>
        /// Gets a reference to the next achievement.
        /// </summary>
        [JsonPropertyName("next_achievement")]
        public AchievementReference NextAchievement { get; private set; }

        /// <summary>
        /// Gets the media associated with this achievement.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; private set; }
    }
}
