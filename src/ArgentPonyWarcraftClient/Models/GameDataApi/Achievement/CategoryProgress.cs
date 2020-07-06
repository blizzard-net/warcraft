using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Progress in an achievement category for a character.
    /// </summary>
    public class CategoryProgress
    {
        /// <summary>
        /// Gets a reference to the achievement category.
        /// </summary>
        [JsonProperty("category")]
        public AchievementCategoryReference Category { get; set; }

        /// <summary>
        /// Gets the number of achievements the character has in this category.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets the number of achievement points the character has in this category.
        /// </summary>
        [JsonProperty("points")]
        public long Points { get; set; }
    }
}
