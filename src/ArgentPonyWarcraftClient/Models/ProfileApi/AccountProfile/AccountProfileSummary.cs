using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A profile summary for an account.
    /// </summary>
    public class AccountProfileSummary
    {
        /// <summary>
        /// Gets links for the profile summary for the account.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; set; }

        /// <summary>
        /// Gets the ID of the profile summary for the account.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the World of Warcraft accounts associated with the account profile.
        /// </summary>
        [JsonPropertyName("wow_accounts")]
        public WowAccount[] WowAccounts { get; set; }

        /// <summary>
        /// Gets a link to the collections for the account.
        /// </summary>
        [JsonPropertyName("collections")]
        public Self Collections { get; set; }
    }
}
