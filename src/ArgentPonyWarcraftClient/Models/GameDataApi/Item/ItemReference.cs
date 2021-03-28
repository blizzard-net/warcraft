using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item.
    /// </summary>
    public record ItemReference
    {
        /// <summary>
        /// Gets the key for the item.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReference"/> class.
        /// </summary>
        /// <param name="key">The key for the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="id">The ID of the item.</param>
        [JsonConstructor]
        public ItemReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
