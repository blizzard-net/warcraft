using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
