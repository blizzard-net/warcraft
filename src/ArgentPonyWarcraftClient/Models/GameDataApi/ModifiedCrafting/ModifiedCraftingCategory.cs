using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Modified Crafting category.
    /// </summary>
    public class ModifiedCraftingCategory
    {
        /// <summary>
        /// Gets links for the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the Modified Crafting category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
