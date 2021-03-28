using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public record TalentReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the talent.</param>
        /// <param name="id">The ID of the talent.</param>
        [JsonConstructor]
        public TalentReferenceWithoutName(Self key, int id)
        {
            Key = key;
            Id = id;
        }
    }
}
