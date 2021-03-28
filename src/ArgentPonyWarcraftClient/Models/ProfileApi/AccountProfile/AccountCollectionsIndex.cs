using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of collection types for an account.
    /// </summary>
    public record AccountCollectionsIndex
    {
        /// <summary>
        /// Gets links for the index of collection types for the account.
        /// </summary>
        [JsonPropertyName("_links")]
        public LinksForAccountProfile Links { get; }

        /// <summary>
        /// Gets a link to the pets collection for the account.
        /// </summary>
        [JsonPropertyName("pets")]
        public Self Pets { get; }

        /// <summary>
        /// Gets a link to the mounts collection for the account.
        /// </summary>
        [JsonPropertyName("mounts")]
        public Self Mounts { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of collection types for the account.</param>
        /// <param name="pets">A link to the pets collection for the account.</param>
        /// <param name="mounts">A link to the mounts collection for the account.</param>
        [JsonConstructor]
        public AccountCollectionsIndex(LinksForAccountProfile links, Self pets, Self mounts)
        {
            Links = links;
            Pets = pets;
            Mounts = mounts;
        }
    }
}
