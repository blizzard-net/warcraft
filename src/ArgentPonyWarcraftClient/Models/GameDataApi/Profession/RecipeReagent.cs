using Newtonsoft.Json;

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
        [JsonProperty("reagent")]
        public ItemReference Reagent { get; set; }

        /// <summary>
        /// Gets the quantity of the reagent required.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
