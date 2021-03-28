using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP talent.
    /// </summary>
    public record PvpTalentReference
    {
        /// <summary>
        /// Gets the key for the PvP talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the PvP talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalentReference"/> class.
        /// </summary>
        /// <param name="key">The key for the PvP talent.</param>
        /// <param name="name">The name of the PvP talent.</param>
        /// <param name="id">The ID of the PvP talent.</param>
        [JsonConstructor]
        public PvpTalentReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
