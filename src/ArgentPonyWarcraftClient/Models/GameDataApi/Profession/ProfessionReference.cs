using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a profession.
    /// </summary>
    public record ProfessionReference
    {
        /// <summary>
        /// Gets the key for the profession.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the profession.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfessionReference"/> class.
        /// </summary>
        /// <param name="key">The key for the profession.</param>
        /// <param name="name">The name of the profession.</param>
        /// <param name="id">The ID of the profession.</param>
        [JsonConstructor]
        public ProfessionReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
