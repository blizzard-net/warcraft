using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public LinksForAccountProfile Links { get; set; }

        /// <summary>
        /// Gets the ID of the profile summary for the account.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the World of Warcraft accounts associated with the account profile.
        /// </summary>
        [JsonProperty("wow_accounts")]
        public WowAccount[] WowAccounts { get; set; }

        /// <summary>
        /// Gets a link to the collections for the account.
        /// </summary>
        [JsonProperty("collections")]
        public Self Collections { get; set; }
    }
}
