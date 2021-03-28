using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest type.
    /// </summary>
    public record QuestTypeReference
    {
        /// <summary>
        /// Gets the key for the quest type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the quest type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the quest type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestTypeReference"/> class.
        /// </summary>
        /// <param name="key">The key for the quest type.</param>
        /// <param name="name">The name of the quest type.</param>
        /// <param name="id">The ID of the quest type.</param>
        [JsonConstructor]
        public QuestTypeReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
