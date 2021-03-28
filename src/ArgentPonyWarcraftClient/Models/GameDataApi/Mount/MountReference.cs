using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a mount.
    /// </summary>
    public record MountReference
    {
        /// <summary>
        /// Gets the key for the mount.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MountReference"/> class.
        /// </summary>
        /// <param name="key">The key for the mount.</param>
        /// <param name="name">The name of the mount.</param>
        /// <param name="id">The ID of the mount.</param>
        [JsonConstructor]
        public MountReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
