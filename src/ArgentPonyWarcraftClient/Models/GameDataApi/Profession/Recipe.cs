using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recipe.
    /// </summary>
    public record Recipe
    {
        /// <summary>
        /// Gets links for the recipe.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the recipe.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the media associated with the recipe.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Gets a reference to the item crafted by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_item")]
        public ItemReference CraftedItem { get; }

        /// <summary>
        /// Gets the reagents required for the recipe.
        /// </summary>
        [JsonPropertyName("reagents")]
        public RecipeReagent[] Reagents { get; }

        /// <summary>
        /// Gets the range of item quantities produced by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_quantity")]
        public CraftedQuantity CraftedQuantity { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe"/> class.
        /// </summary>
        /// <param name="links">Links for the recipe.</param>
        /// <param name="id">The ID of the recipe.</param>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="description">The description of the recipe.</param>
        /// <param name="media">The media associated with the recipe.</param>
        /// <param name="craftedItem">A reference to the item crafted by this recipe.</param>
        /// <param name="reagents">The reagents required for the recipe.</param>
        /// <param name="craftedQuantity">The range of item quantities produced by this recipe.</param>
        [JsonConstructor]
        public Recipe(Links links, int id, string name, string description, Media media, ItemReference craftedItem, RecipeReagent[] reagents, CraftedQuantity craftedQuantity)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            Media = media;
            CraftedItem = craftedItem;
            Reagents = reagents;
            CraftedQuantity = craftedQuantity;
        }
    }
}
