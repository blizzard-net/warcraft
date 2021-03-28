using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A profile summary for an account.
    /// </summary>
    public record AccountProfileSummary
    {
        /// <summary>
        /// Gets links for the profile summary for the account.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; }

        /// <summary>
        /// Gets the ID of the profile summary for the account.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the World of Warcraft accounts associated with the account profile.
        /// </summary>
        [JsonPropertyName("wow_accounts")]
        public WowAccount[] WowAccounts { get; }

        /// <summary>
        /// Gets a link to the collections for the account.
        /// </summary>
        [JsonPropertyName("collections")]
        public Self Collections { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProfileSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the profile summary for the account.</param>
        /// <param name="id">The ID of the profile summary for the account.</param>
        /// <param name="wowAccounts">The World of Warcraft accounts associated with the account profile.</param>
        /// <param name="collections">A link to the collections for the account.</param>
        [JsonConstructor]
        public AccountProfileSummary(LinksForAccountProfile links, int id, WowAccount[] wowAccounts, Self collections)
        {
            Links = links;
            Id = id;
            WowAccounts = wowAccounts;
            Collections = collections;
        }
    }
}
