namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Media API.
/// </summary>
public interface ICharacterMediaApi
{
    /// <summary>
    ///     Get a summary of the media assets available for a character (such as an avatar render).
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character media summary.
    /// </returns>
    Task<RequestResult<CharacterMediaSummary>> GetCharacterMediaSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a summary of the media assets available for a character (such as an avatar render).
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character media summary.
    /// </returns>
    Task<RequestResult<CharacterMediaSummary>> GetCharacterMediaSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
