using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reagent for a recipe.
    /// </summary>
    public record RecipeReagent
    {
        /// <summary>
        /// Gets a reference to the reagent item.
        /// </summary>
        [JsonPropertyName("reagent")]
        public ItemReference Reagent { get; }

        /// <summary>
        /// Gets the quantity of the reagent required.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeReagent"/> class.
        /// </summary>
        /// <param name="reagent">A reference to the reagent item.</param>
        /// <param name="quantity">The quantity of the reagent required.</param>
        [JsonConstructor]
        public RecipeReagent(ItemReference reagent, int quantity)
        {
            Reagent = reagent;
            Quantity = quantity;
        }
    }
}
