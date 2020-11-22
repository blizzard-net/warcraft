using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Modified Crafting categories.
    /// </summary>
    public class ModifiedCraftingCategoryIndex
    {
        /// <summary>
        /// Gets links for the index of Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public ModifiedCraftingCategoryReference[] Categories { get; set; }
    }
}
