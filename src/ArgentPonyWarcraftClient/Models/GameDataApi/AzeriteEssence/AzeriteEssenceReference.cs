using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an azerite essence.
    /// </summary>
    public record AzeriteEssenceReference
    {
        /// <summary>
        /// Gets the key for the azerite essence.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeriteEssenceReference"/> class.
        /// </summary>
        /// <param name="key">The key for the azerite essence.</param>
        /// <param name="name">The name of the azerite essence.</param>
        /// <param name="id">The ID of the azerite essence.</param>
        [JsonConstructor]
        public AzeriteEssenceReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
