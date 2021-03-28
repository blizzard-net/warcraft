using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest.
    /// </summary>
    public record QuestReference
    {
        /// <summary>
        /// Gets the key for the quest.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the quest.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the quest.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestReference"/> class.
        /// </summary>
        /// <param name="key">The key for the quest.</param>
        /// <param name="name">The name of the quest.</param>
        /// <param name="id">The ID of the quest.</param>
        [JsonConstructor]
        public QuestReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
