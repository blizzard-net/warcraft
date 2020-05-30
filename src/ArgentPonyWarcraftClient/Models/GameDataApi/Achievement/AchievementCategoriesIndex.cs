using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of achievement categories.
    /// </summary>
    public class AchievementCategoriesIndex
    {
        /// <summary>
        /// Gets links for the index of achievement categories.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets references to achievement categories.
        /// </summary>
        [JsonProperty("categories")]
        public AchievementCategoryReference[] Categories { get; private set; }

        /// <summary>
        /// Gets references to root achievement categories.
        /// </summary>
        [JsonProperty("root_categories")]
        public AchievementCategoryReference[] RootCategories { get; private set; }

        /// <summary>
        /// Gets references to guild achievement categories.
        /// </summary>
        [JsonProperty("guild_categories")]
        public AchievementCategoryReference[] GuildCategories { get; private set; }
    }
}
