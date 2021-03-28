using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest categories (such as quests for a specific class, profession, or storyline).
    /// </summary>
    public record QuestCategoriesIndex
    {
        /// <summary>
        /// Gets links for the index of quest categories.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the quest categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public QuestCategoryReference[] Categories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestCategoriesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of quest categories.</param>
        /// <param name="categories">References to the quest categories.</param>
        [JsonConstructor]
        public QuestCategoriesIndex(Links links, QuestCategoryReference[] categories)
        {
            Links = links;
            Categories = categories;
        }
    }
}
