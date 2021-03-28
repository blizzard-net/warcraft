using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest area.
    /// </summary>
    public record QuestAreaReference
    {
        /// <summary>
        /// Gets the key for the quest area.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the quest area.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestAreaReference"/> class.
        /// </summary>
        /// <param name="key">The key for the quest area.</param>
        /// <param name="name">The name of the quest area.</param>
        /// <param name="id">The ID of the quest area.</param>
        [JsonConstructor]
        public QuestAreaReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
