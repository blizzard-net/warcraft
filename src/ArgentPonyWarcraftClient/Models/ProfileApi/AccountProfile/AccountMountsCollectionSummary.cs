using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the mounts an account has obtained.
    /// </summary>
    public record AccountMountsCollectionSummary
    {
        /// <summary>
        /// Gets links for the summary of the mounts the account has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; }

        /// <summary>
        /// Gets the mounts for the account.
        /// </summary>
        [JsonPropertyName("mounts")]
        public AccountMount[] Mounts { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountMountsCollectionSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the summary of the mounts the account has obtained.</param>
        /// <param name="mounts">The mounts for the account.</param>
        [JsonConstructor]
        public AccountMountsCollectionSummary(LinksForAccountProfile links, AccountMount[] mounts)
        {
            Links = links;
            Mounts = mounts;
        }
    }
}
