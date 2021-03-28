using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The parent index for Modified Crafting.
    /// </summary>
    public record ModifiedCraftingIndex
    {
        /// <summary>
        /// Gets links for the parent index for Modified Crafting.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the index of Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public Self Categories { get; }

        /// <summary>
        /// Gets a reference to the Modified Crafting reagent slot types.
        /// </summary>
        [JsonPropertyName("slot_types")]
        public Self SlotTypes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the parent index for Modified Crafting.</param>
        /// <param name="categories">A reference to the index of Modified Crafting categories.</param>
        /// <param name="slotTypes">A reference to the Modified Crafting reagent slot types.</param>
        [JsonConstructor]
        public ModifiedCraftingIndex(Links links, Self categories, Self slotTypes)
        {
            Links = links;
            Categories = categories;
            SlotTypes = slotTypes;
        }
    }
}
