using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a region.
    /// </summary>
    public record RegionReference
    {
        /// <summary>
        /// Gets the key for the region.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the region.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionReference"/> class.
        /// </summary>
        /// <param name="key">The key for the region.</param>
        /// <param name="name">The name of the region.</param>
        /// <param name="id">The ID of the region.</param>
        [JsonConstructor]
        public RegionReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
