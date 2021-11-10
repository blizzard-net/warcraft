namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character PvP API.
/// </summary>
public interface ICharacterPvpApi
{
    /// <summary>
    ///     Get the PvP bracket statistics for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="pvpBracket">The PvP bracket type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP bracket statistics for a character.
    /// </returns>
    Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace);

    /// <summary>
    ///     Get the PvP bracket statistics for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="pvpBracket">The PvP bracket type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP bracket statistics for a character.
    /// </returns>
    Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the PvP summary for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP summary for a character.
    /// </returns>
    Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the PvP summary for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP summary for a character.
    /// </returns>
    Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
