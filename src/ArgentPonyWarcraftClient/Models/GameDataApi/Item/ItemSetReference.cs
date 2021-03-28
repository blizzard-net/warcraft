using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item set.
    /// </summary>
    public record ItemSetReference
    {
        /// <summary>
        /// Gets the key for the item set.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSetReference"/> class.
        /// </summary>
        /// <param name="key">The key for the item set.</param>
        /// <param name="name">The name of the item set.</param>
        /// <param name="id">The ID of the item set.</param>
        [JsonConstructor]
        public ItemSetReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
