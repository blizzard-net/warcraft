using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mounts.
    /// </summary>
    public class MountsIndex
    {
        /// <summary>
        /// Gets links for the index of mounts.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mounts.
        /// </summary>
        [JsonPropertyName("mounts")]
        public MountReference[] Mounts { get; set; }
    }
}
