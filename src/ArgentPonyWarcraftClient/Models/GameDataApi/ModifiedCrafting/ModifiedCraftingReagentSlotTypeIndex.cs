using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Modified Crafting reagent slot types.
    /// </summary>
    public class ModifiedCraftingReagentSlotTypeIndex
    {
        /// <summary>
        /// Gets links for the index of Modified Crafting reagent slot types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }
    }
}
