using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP tier.
    /// </summary>
    public record PvpTierReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the PvP tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTierReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the PvP tier.</param>
        /// <param name="id">The ID of the PvP tier.</param>
        [JsonConstructor]
        public PvpTierReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
