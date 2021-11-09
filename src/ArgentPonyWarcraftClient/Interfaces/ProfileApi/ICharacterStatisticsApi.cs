namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Statistics API.
/// </summary>
public interface ICharacterStatisticsApi
{
    /// <summary>
    ///     Get a statistics summary for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A statistics summary for a character.
    /// </returns>
    Task<RequestResult<CharacterStatisticsSummary>> GetCharacterStatisticsSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a statistics summary for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A statistics summary for a character.
    /// </returns>
    Task<RequestResult<CharacterStatisticsSummary>> GetCharacterStatisticsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
