using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a reputation faction.
    /// </summary>
    public record ReputationFactionReference
    {
        /// <summary>
        /// Gets the key for the reputation faction.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the reputation faction.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the reputation faction.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationFactionReference"/> class.
        /// </summary>
        /// <param name="key">The key for the reputation faction.</param>
        /// <param name="name">The name of the reputation faction.</param>
        /// <param name="id">The ID of the reputation faction.</param>
        [JsonConstructor]
        public ReputationFactionReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
