using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
