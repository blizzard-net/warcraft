namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Collections API.
/// </summary>
public interface ICharacterCollectionsApi
{
    /// <summary>
    ///     Get the specified character collections index.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character collections index.
    /// </returns>
    Task<RequestResult<CharacterCollectionsIndex>> GetCharacterCollectionsIndexAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character collections index.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character collections index.
    /// </returns>
    Task<RequestResult<CharacterCollectionsIndex>> GetCharacterCollectionsIndexAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified character mounts collection summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character mounts collection summary.
    /// </returns>
    Task<RequestResult<CharacterMountsCollectionSummary>> GetCharacterMountsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character mounts collection summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character mounts collection summary.
    /// </returns>
    Task<RequestResult<CharacterMountsCollectionSummary>> GetCharacterMountsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified character pets collection summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character pets collection summary.
    /// </returns>
    Task<RequestResult<CharacterPetsCollectionSummary>> GetCharacterPetsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character pets collection summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character pets collection summary.
    /// </returns>
    Task<RequestResult<CharacterPetsCollectionSummary>> GetCharacterPetsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
