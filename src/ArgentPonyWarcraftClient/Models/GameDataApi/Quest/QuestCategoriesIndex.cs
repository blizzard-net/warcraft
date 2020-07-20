using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest categories (such as quests for a specific class, profession, or storyline).
    /// </summary>
    public class QuestCategoriesIndex
    {
        /// <summary>
        /// Gets links for the index of quest categories.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the quest categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public QuestCategoryReference[] Categories { get; set; }
    }
}
