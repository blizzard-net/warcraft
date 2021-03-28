using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a zone.
    /// </summary>
    public record ZoneReference
    {
        /// <summary>
        /// Gets the key for the zone.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the zone.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneReference"/> class.
        /// </summary>
        /// <param name="key">The key for the zone.</param>
        /// <param name="name">The name of the zone.</param>
        [JsonConstructor]
        public ZoneReference(Self key, string name)
        {
            Key = key;
            Name = name;
        }
    }
}
