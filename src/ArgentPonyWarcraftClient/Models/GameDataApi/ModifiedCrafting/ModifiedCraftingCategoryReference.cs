using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Modified Crafting category.
    /// </summary>
    public record ModifiedCraftingCategoryReference
    {
        /// <summary>
        /// Gets the key for the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingCategoryReference"/> class.
        /// </summary>
        /// <param name="key">The key for the Modified Crafting category.</param>
        /// <param name="name">The name of the Modified Crafting category.</param>
        /// <param name="id">The ID of the Modified Crafting category.</param>
        [JsonConstructor]
        public ModifiedCraftingCategoryReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
