using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Modified Crafting reagent slot types.
    /// </summary>
    public record ModifiedCraftingReagentSlotTypeIndex
    {
        /// <summary>
        /// Gets links for the index of Modified Crafting reagent slot types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the Modified Crafting reagent slot types.
        /// </summary>
        [JsonPropertyName("slot_types")]
        public ModifiedCraftingReagentSlotTypeReference[] SlotTypes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingReagentSlotTypeIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of Modified Crafting reagent slot types.</param>
        /// <param name="slotTypes">References to the Modified Crafting reagent slot types.</param>
        [JsonConstructor]
        public ModifiedCraftingReagentSlotTypeIndex(Links links, ModifiedCraftingReagentSlotTypeReference[] slotTypes)
        {
            Links = links;
            SlotTypes = slotTypes;
        }
    }
}
