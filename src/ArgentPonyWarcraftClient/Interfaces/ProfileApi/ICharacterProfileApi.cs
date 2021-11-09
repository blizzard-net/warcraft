namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Profile API.
/// </summary>
public interface ICharacterProfileApi
{
    /// <summary>
    ///     Get the specified character profile summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character profile summary.
    /// </returns>
    Task<RequestResult<CharacterProfileSummary>> GetCharacterProfileSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character profile summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character profile summary.
    /// </returns>
    Task<RequestResult<CharacterProfileSummary>> GetCharacterProfileSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified character status.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character status.
    /// </returns>
    Task<RequestResult<CharacterStatus>> GetCharacterStatusAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character status.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character status.
    /// </returns>
    Task<RequestResult<CharacterStatus>> GetCharacterStatusAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
