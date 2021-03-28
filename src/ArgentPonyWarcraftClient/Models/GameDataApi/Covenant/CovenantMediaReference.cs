using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to media for a particular covenant.
    /// </summary>
    public record CovenantMediaReference
    {
        /// <summary>
        /// Gets the key for the covenant media reference.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the Id for the covenant media reference.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantMediaReference"/> class.
        /// </summary>
        /// <param name="key">The key for the covenant media reference.</param>
        /// <param name="id">The Id for the covenant media reference.</param>
        [JsonConstructor]
        public CovenantMediaReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
