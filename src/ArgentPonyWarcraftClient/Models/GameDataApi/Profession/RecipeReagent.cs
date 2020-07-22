using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reagent for a recipe.
    /// </summary>
    public class RecipeReagent
    {
        /// <summary>
        /// Gets a reference to the reagent item.
        /// </summary>
        [JsonPropertyName("reagent")]
        public ItemReference Reagent { get; set; }

        /// <summary>
        /// Gets the quantity of the reagent required.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
