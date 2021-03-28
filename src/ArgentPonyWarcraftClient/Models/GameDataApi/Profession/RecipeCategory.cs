using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recipe category.
    /// </summary>
    public record RecipeCategory
    {
        /// <summary>
        /// Gets the name of the recipe category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the recipes in the recipe category.
        /// </summary>
        [JsonPropertyName("recipes")]
        public RecipeReference[] Recipes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeCategory"/> class.
        /// </summary>
        /// <param name="name">The name of the recipe category.</param>
        /// <param name="recipes">The recipes in the recipe category.</param>
        [JsonConstructor]
        public RecipeCategory(string name, RecipeReference[] recipes)
        {
            Name = name;
            Recipes = recipes;
        }
    }
}
