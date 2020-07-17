using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the mounts an account has obtained.
    /// </summary>
    public class AccountMountsCollectionSummary
    {
        /// <summary>
        /// Gets links for the summary of the mounts the account has obtained.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; set; }

        /// <summary>
        /// Gets the mounts for the account.
        /// </summary>
        [JsonPropertyName("mounts")]
        public AccountMount[] Mounts { get; set; }
    }
}
