using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item.
    /// </summary>
    public record ItemReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the item.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the item.</param>
        /// <param name="id">The ID of the item.</param>
        [JsonConstructor]
        public ItemReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
