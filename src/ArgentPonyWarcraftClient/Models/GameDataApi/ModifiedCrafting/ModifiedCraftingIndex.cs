using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The parent index for Modified Crafting.
    /// </summary>
    public class ModifiedCraftingIndex
    {
        /// <summary>
        /// Gets links for the parent index for Modified Crafting.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the index of Modified Crafting categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public Self Categories { get; set; }

        /// <summary>
        /// Gets a reference to the Modified Crafting reagent slot types.
        /// </summary>
        [JsonPropertyName("slot_types")]
        public Self SlotTypes { get; set; }
    }
}
