using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a power type.
    /// </summary>
    public record PowerTypeReference
    {
        /// <summary>
        /// Gets the key for the power type.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the power type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the power type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerTypeReference"/> class.
        /// </summary>
        /// <param name="key">The key for the power type.</param>
        /// <param name="name">The name of the power type.</param>
        /// <param name="id">The ID of the power type.</param>
        [JsonConstructor]
        public PowerTypeReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
