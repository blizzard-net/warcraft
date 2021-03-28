using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of achievement categories.
    /// </summary>
    public record AchievementCategoriesIndex
    {
        /// <summary>
        /// Gets links for the index of achievement categories.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to achievement categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public AchievementCategoryReference[] Categories { get; }

        /// <summary>
        /// Gets references to root achievement categories.
        /// </summary>
        [JsonPropertyName("root_categories")]
        public AchievementCategoryReference[] RootCategories { get; }

        /// <summary>
        /// Gets references to guild achievement categories.
        /// </summary>
        [JsonPropertyName("guild_categories")]
        public AchievementCategoryReference[] GuildCategories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementCategoriesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of achievement categories.</param>
        /// <param name="categories">References to achievement categories.</param>
        /// <param name="rootCategories">References to root achievement categories.</param>
        /// <param name="guildCategories">References to guild achievement categories.</param>
        [JsonConstructor]
        public AchievementCategoriesIndex(Links links, AchievementCategoryReference[] categories, AchievementCategoryReference[] rootCategories, AchievementCategoryReference[] guildCategories)
        {
            Links = links;
            Categories = categories;
            RootCategories = rootCategories;
            GuildCategories = guildCategories;
        }
    }
}
