using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a dungeon or raid.
    /// </summary>
    public record InstanceReference
    {
        /// <summary>
        /// Gets the key for the instance.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the instance.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceReference"/> class.
        /// </summary>
        /// <param name="key">The key for the instance.</param>
        /// <param name="name">The name of the instance.</param>
        /// <param name="id">The ID of the instance.</param>
        [JsonConstructor]
        public InstanceReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
