using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tier of content.
    /// </summary>
    public record Tier
    {
        /// <summary>
        /// Gets the key for the tier.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tier"/> class.
        /// </summary>
        /// <param name="key">The key for the tier.</param>
        /// <param name="name">The name of the tier.</param>
        /// <param name="id">The ID of the tier.</param>
        [JsonConstructor]
        public Tier(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
