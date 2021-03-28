using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Modified Crafting categories.
    /// </summary>
    public record ModifiedCraftingCategoryIndex
    {
        /// <summary>
        /// Gets links for the index of Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public ModifiedCraftingCategoryReference[] Categories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingCategoryIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of Modified Crafting categories.</param>
        /// <param name="categories">References to the Modified Crafting categories.</param>
        [JsonConstructor]
        public ModifiedCraftingCategoryIndex(Links links, ModifiedCraftingCategoryReference[] categories)
        {
            Links = links;
            Categories = categories;
        }
    }
}
