using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recipe category.
    /// </summary>
    public class RecipeCategory
    {
        /// <summary>
        /// Gets the name of the recipe category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the recipes in the recipe category.
        /// </summary>
        [JsonPropertyName("recipes")]
        public RecipeReference[] Recipes { get; set; }
    }
}
