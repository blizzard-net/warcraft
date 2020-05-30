using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; private set; }

        /// <summary>
        /// Gets a reference to the achievement category to which this achievement belongs.
        /// </summary>
        [JsonProperty("category")]
        public AchievementCategoryReference Category { get; private set; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description of this achievement.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the number of achievement points associated with this achievement.
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this achievement is account-wide.
        /// </summary>
        [JsonProperty("is_account_wide")]
        public bool IsAccountWide { get; private set; }

        /// <summary>
        /// Gets the criteria for this achievement.
        /// </summary>
        [JsonProperty("criteria")]
        public AchievementCriteria Criteria { get; private set; }

        /// <summary>
        /// Gets a reference to the next achievement.
        /// </summary>
        [JsonProperty("next_achievement")]
        public AchievementReference NextAchievement { get; private set; }

        /// <summary>
        /// Gets the media associated with this achievement.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        [JsonProperty("display_order")]
        public int DisplayOrder { get; private set; }
    }
}
