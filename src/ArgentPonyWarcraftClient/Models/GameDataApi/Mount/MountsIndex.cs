using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mounts.
    /// </summary>
    public record MountsIndex
    {
        /// <summary>
        /// Gets links for the index of mounts.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the mounts.
        /// </summary>
        [JsonPropertyName("mounts")]
        public MountReference[] Mounts { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MountsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mounts.</param>
        /// <param name="mounts">References to the mounts.</param>
        [JsonConstructor]
        public MountsIndex(Links links, MountReference[] mounts)
        {
            Links = links;
            Mounts = mounts;
        }
    }
}
