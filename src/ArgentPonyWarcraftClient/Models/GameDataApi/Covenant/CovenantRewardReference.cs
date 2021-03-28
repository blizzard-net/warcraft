using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a covenant reward.
    /// </summary>
    public record CovenantRewardReference
    {
        /// <summary>
        /// Gets the key for the covenant reward.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name for the covenant reward.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the Id for the covenant reward.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CovenantRewardReference"/> class.
        /// </summary>
        /// <param name="key">The key for the covenant reward.</param>
        /// <param name="name">The name for the covenant reward.</param>
        /// <param name="id">The Id for the covenant reward.</param>
        [JsonConstructor]
        public CovenantRewardReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
