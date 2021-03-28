using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Recipe media.
    /// </summary>
    public record RecipeMedia
    {
        /// <summary>
        /// Gets links for the recipe media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the recipe media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the recipe.</param>
        [JsonConstructor]
        public RecipeMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
