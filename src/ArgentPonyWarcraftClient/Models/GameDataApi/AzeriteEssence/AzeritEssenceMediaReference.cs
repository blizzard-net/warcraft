using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to azerite essence media.
    /// </summary>
    public record AzeritEssenceMediaReference
    {
        /// <summary>
        /// Gets the key for the azerite essence media.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeritEssenceMediaReference"/> class.
        /// </summary>
        /// <param name="key">The key for the azerite essence media.</param>
        /// <param name="id">The ID of the azerite essence.</param>
        [JsonConstructor]
        public AzeritEssenceMediaReference(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
