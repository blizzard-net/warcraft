using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public MountReference[] Mounts { get; set; }
    }
}
