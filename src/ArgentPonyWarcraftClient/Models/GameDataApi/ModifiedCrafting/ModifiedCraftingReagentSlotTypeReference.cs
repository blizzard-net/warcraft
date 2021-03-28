using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Modified Crafting reagent slot type.
    /// </summary>
    public record ModifiedCraftingReagentSlotTypeReference
    {
        /// <summary>
        /// Gets the key for the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the Modified Crafting reagent slot type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingReagentSlotTypeReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Modified Crafting reagent slot type.</param>
        /// <param name="name">The name of the Modified Crafting reagent slot type.</param>
        /// <param name="id">The ID of the Modified Crafting reagent slot type.</param>
        [JsonConstructor]
        public ModifiedCraftingReagentSlotTypeReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
