using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a covenant.
    /// </summary>
    public record CovenantReference
    {
        /// <summary>
        /// Gets the key for the covenant.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the covenant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the covenant.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantReference"/> class.
        /// </summary>
        /// <param name="key">The key for the covenant.</param>
        /// <param name="name">The name of the covenant.</param>
        /// <param name="id">The ID of the covenant.</param>
        [JsonConstructor]
        public CovenantReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
