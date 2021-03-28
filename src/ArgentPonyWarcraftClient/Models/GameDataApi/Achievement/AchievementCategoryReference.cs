using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an achievement category.
    /// </summary>
    public record AchievementCategoryReference
    {
        /// <summary>
        /// Gets the key for this achievement category.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementCategoryReference"/> class.
        /// </summary>
        /// <param name="key">The key for this achievement category.</param>
        /// <param name="name">The name of this achievement category.</param>
        /// <param name="id">The ID of this achievement category.</param>
        [JsonConstructor]
        public AchievementCategoryReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
