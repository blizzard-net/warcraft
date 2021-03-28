using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Progress in an achievement category for a character.
    /// </summary>
    public record CategoryProgress
    {
        /// <summary>
        /// Gets a reference to the achievement category.
        /// </summary>
        [JsonPropertyName("category")]
        public AchievementCategoryReference Category { get; }

        /// <summary>
        /// Gets the number of achievements the character has in this category.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; }

        /// <summary>
        /// Gets the number of achievement points the character has in this category.
        /// </summary>
        [JsonPropertyName("points")]
        public int Points { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryProgress"/> class.
        /// </summary>
        /// <param name="category">A reference to the achievement category.</param>
        /// <param name="quantity">The number of achievements the character has in this category.</param>
        /// <param name="points">The number of achievement points the character has in this category.</param>
        [JsonConstructor]
        public CategoryProgress(AchievementCategoryReference category, int quantity, int points)
        {
            Category = category;
            Quantity = quantity;
            Points = points;
        }
    }
}
