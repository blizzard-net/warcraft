namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Profile API.
/// </summary>
public interface IAccountProfileApi
{
    /// <summary>
    ///     Get a profile summary for an account.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The profile summary for the account.
    /// </returns>
    Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace);

    /// <summary>
    ///     Get a profile summary for an account.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The profile summary for the account.
    /// </returns>
    Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a protected profile summary for a character.
    /// </summary>
    /// <param name="realmId">The ID of the character's realm.</param>
    /// <param name="characterId">The ID of the character.</param>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The protected profile summary for the character.
    /// </returns>
    Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace);

    /// <summary>
    ///     Get a protected profile summary for a character.
    /// </summary>
    /// <param name="realmId">The ID of the character's realm.</param>
    /// <param name="characterId">The ID of the character.</param>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The protected profile summary for the character.
    /// </returns>
    Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get an index of collection types for an account.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     An index of collection types for the account.
    /// </returns>
    Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace);

    /// <summary>
    ///     Get an index of collection types for an account.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     An index of collection types for the account.
    /// </returns>
    Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a summary of the mounts an account has obtained.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of the mounts the account has obtained.
    /// </returns>
    Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace);

    /// <summary>
    ///     Get a summary of the mounts an account has obtained.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of the mounts the account has obtained.
    /// </returns>
    Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a summary of the battle pets an account has obtained.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of the battle pets the account has obtained.
    /// </returns>
    Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace);

    /// <summary>
    ///     Get a summary of the battle pets an account has obtained.
    /// </summary>
    /// <param name="accessToken">The OAuth access token for the user.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of the battle pets the account has obtained.
    /// </returns>
    Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale);
}
