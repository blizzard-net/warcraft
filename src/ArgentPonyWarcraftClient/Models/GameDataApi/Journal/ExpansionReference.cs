using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to game expansion.
    /// </summary>
    public record ExpansionReference
    {
        /// <summary>
        /// Gets the key for the expansion.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpansionReference"/> class.
        /// </summary>
        /// <param name="key">The key for the expansion.</param>
        /// <param name="name">The name of the expansion.</param>
        /// <param name="id">The ID of the expansion.</param>
        [JsonConstructor]
        public ExpansionReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
