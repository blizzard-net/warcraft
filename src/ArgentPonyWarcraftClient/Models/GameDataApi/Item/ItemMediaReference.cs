using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to item media.
    /// </summary>
    public record ItemMediaReference
    {
        /// <summary>
        /// Gets the key for the item media.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMediaReference"/> class.
        /// </summary>
        /// <param name="key">The key for the item media.</param>
        /// <param name="id">The ID of the item.</param>
        [JsonConstructor]
        public ItemMediaReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
