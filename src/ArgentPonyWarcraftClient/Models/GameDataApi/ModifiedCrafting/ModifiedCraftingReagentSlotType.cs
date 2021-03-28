using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Modified Crafting reagent slot type.
    /// </summary>
    public class ModifiedCraftingReagentSlotType
    {
        /// <summary>
        /// Gets links for the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a description of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets references to the Modified Crafting categories that are compatible with this reagent slot type.
        /// </summary>
        [JsonPropertyName("compatible_categories")]
        public ModifiedCraftingCategoryReference[] CompatibleCategories { get; set; }
    }
}
