using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a recipe.
    /// </summary>
    public record RecipeReference
    {
        /// <summary>
        /// Gets the key for the recipe.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeReference"/> class.
        /// </summary>
        /// <param name="key">The key for the recipe.</param>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="id">The ID of the recipe.</param>
        [JsonConstructor]
        public RecipeReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
