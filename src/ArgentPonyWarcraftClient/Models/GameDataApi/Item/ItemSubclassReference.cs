using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item subclass.
    /// </summary>
    public record ItemSubclassReference
    {
        /// <summary>
        /// Gets the key for the item subclass.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the item subclass.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the item subclass.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSubclassReference"/> class.
        /// </summary>
        /// <param name="key">The key for the item subclass.</param>
        /// <param name="name">The name of the item subclass.</param>
        /// <param name="id">The ID of the item subclass.</param>
        [JsonConstructor]
        public ItemSubclassReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
