using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a conduit.
    /// </summary>
    public record ConduitReference
    {
        /// <summary>
        /// Gets the key for the conduit.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the conduit.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the conduit.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConduitReference"/> class.
        /// </summary>
        /// <param name="key">The key for the conduit.</param>
        /// <param name="name">The name of the conduit.</param>
        /// <param name="id">The ID of the conduit.</param>
        [JsonConstructor]
        public ConduitReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
