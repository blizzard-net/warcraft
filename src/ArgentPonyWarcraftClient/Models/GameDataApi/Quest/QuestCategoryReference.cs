using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest category.
    /// </summary>
    public record QuestCategoryReference
    {
        /// <summary>
        /// Gets the key for the quest category.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the quest category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the quest category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestCategoryReference"/> class.
        /// </summary>
        /// <param name="key">The key for the quest category.</param>
        /// <param name="name">The name of the quest category.</param>
        /// <param name="id">The ID of the quest category.</param>
        [JsonConstructor]
        public QuestCategoryReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
