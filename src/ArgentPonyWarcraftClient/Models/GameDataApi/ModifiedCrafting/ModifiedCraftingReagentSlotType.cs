using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Modified Crafting reagent slot type.
    /// </summary>
    public record ModifiedCraftingReagentSlotType
    {
        /// <summary>
        /// Gets links for the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a description of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets references to the Modified Crafting categories that are compatible with this reagent slot type.
        /// </summary>
        [JsonPropertyName("compatible_categories")]
        public ModifiedCraftingCategoryReference[] CompatibleCategories { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingReagentSlotType"/> class.
        /// </summary>
        /// <param name="links">Links for the Modified Crafting reagent slot type.</param>
        /// <param name="id">The ID of the Modified Crafting reagent slot type.</param>
        /// <param name="description">A description of the Modified Crafting reagent slot type.</param>
        /// <param name="compatibleCategories">References to the Modified Crafting categories that are compatible with this reagent slot type.</param>
        [JsonConstructor]
        public ModifiedCraftingReagentSlotType(Links links, int id, string description, ModifiedCraftingCategoryReference[] compatibleCategories)
        {
            Links = links;
            Id = id;
            Description = description;
            CompatibleCategories = compatibleCategories;
        }
    }
}
