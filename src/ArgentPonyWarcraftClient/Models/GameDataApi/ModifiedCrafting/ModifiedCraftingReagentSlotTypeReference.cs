using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient.Models.GameDataApi.ModifiedCrafting
{
    /// <summary>
    /// A Modified Crafting reagent slot type.
    /// </summary>
    public class ModifiedCraftingReagentSlotTypeReference
    {
        /// <summary>
        /// Gets the key for the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
