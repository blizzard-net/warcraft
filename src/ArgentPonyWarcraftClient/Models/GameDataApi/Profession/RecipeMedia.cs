using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
