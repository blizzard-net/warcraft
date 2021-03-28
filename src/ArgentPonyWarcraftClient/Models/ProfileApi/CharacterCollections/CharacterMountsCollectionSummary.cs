using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the mounts a character has obtained.
    /// </summary>
    public record CharacterMountsCollectionSummary
    {
        /// <summary>
        /// Gets links for the character mounts collection summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the mounts this character has collected.
        /// </summary>
        [JsonPropertyName("mounts")]
        public CharacterMount[] Mounts { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMountsCollectionSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character mounts collection summary.</param>
        /// <param name="mounts">The mounts this character has collected.</param>
        [JsonConstructor]
        public CharacterMountsCollectionSummary(Links links, CharacterMount[] mounts)
        {
            Links = links;
            Mounts = mounts;
        }
    }
}
