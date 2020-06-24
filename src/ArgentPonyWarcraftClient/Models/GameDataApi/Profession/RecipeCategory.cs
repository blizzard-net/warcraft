using Newtonsoft.Json;

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
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the recipes in the recipe category.
        /// </summary>
        [JsonProperty("recipes")]
        public RecipeReference[] Recipes { get; set; }
    }
}
