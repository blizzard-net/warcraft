using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation tier.
    /// </summary>
    public record ReputationTierReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the reputation tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationTierReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the reputation tier.</param>
        /// <param name="id">The ID of the reputation tier.</param>
        [JsonConstructor]
        public ReputationTierReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
