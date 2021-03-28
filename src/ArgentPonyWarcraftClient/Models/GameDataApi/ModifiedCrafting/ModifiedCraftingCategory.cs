using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Modified Crafting category.
    /// </summary>
    public record ModifiedCraftingCategory
    {
        /// <summary>
        /// Gets links for the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifiedCraftingCategory"/> class.
        /// </summary>
        /// <param name="links">Links for the Modified Crafting category.</param>
        /// <param name="id">The ID of the Modified Crafting category.</param>
        /// <param name="name">The name of the Modified Crafting category.</param>
        [JsonConstructor]
        public ModifiedCraftingCategory(Links links, int id, string name)
        {
            Links = links;
            Id = id;
            Name = name;
        }
    }
}
