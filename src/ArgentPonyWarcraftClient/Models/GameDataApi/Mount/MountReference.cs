using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a mount.
    /// </summary>
    public class MountReference
    {
        /// <summary>
        /// Gets the key for the mount.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
