using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item class.
    /// </summary>
    public record ItemClassReference
    {
        /// <summary>
        /// Gets the key for the item class.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the item class.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClassReference"/> class.
        /// </summary>
        /// <param name="key">The key for the item class.</param>
        /// <param name="name">The name of the item class.</param>
        /// <param name="id">The ID of the item class.</param>
        [JsonConstructor]
        public ItemClassReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
