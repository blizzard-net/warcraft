namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Achievements API.
/// </summary>
public interface ICharacterAchievementsApi
{
    /// <summary>
    ///     Get the specified character achievement summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character achievement summary.
    /// </returns>
    Task<RequestResult<CharacterAchievementsSummary>> GetCharacterAchievementsSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character achievement summary.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character achievement summary.
    /// </returns>
    Task<RequestResult<CharacterAchievementsSummary>> GetCharacterAchievementsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified character achievement statistics.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified character achievement statistics.
    /// </returns>
    Task<RequestResult<CharacterAchievementStatistics>> GetCharacterAchievementStatisticsAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified character achievement statistics.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified character achievement statistics.
    /// </returns>
    Task<RequestResult<CharacterAchievementStatistics>> GetCharacterAchievementStatisticsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
