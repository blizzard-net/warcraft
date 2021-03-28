using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Recipe media.
    /// </summary>
    public class RecipeMedia
    {
        /// <summary>
        /// Gets links for the recipe media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
