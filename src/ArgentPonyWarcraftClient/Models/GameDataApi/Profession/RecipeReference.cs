using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a recipe.
    /// </summary>
    public class RecipeReference
    {
        /// <summary>
        /// Gets the key for the recipe.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
