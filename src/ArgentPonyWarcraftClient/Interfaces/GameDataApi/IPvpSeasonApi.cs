namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft PvP Season API.
/// </summary>
public interface IPvpSeasonApi
{
    /// <summary>
    ///     Gets an index of PvP seasons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of PvP seasons.
    /// </returns>
    Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of PvP seasons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of PvP seasons.
    /// </returns>
    Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified PvP season.
    /// </returns>
    Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace);

    /// <summary>
    ///     Get the specified PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified PvP season.
    /// </returns>
    Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of PvP leaderboards for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     An index of PvP leaderboards for a PvP season.
    /// </returns>
    Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpSeasonId, string @namespace);

    /// <summary>
    ///     Gets an index of PvP leaderboards for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     An index of PvP leaderboards for a PvP season.
    /// </returns>
    Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpSeasonId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets the PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="pvpBracket">The PvP bracket type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </returns>
    Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpSeasonId, string pvpBracket, string @namespace);

    /// <summary>
    ///     Gets the PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="pvpBracket">The PvP bracket type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP leaderboard of a specific PvP bracket for a PvP season.
    /// </returns>
    Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpSeasonId, string pvpBracket, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of PvP rewards for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     An index of PvP rewards for a PvP season.
    /// </returns>
    Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpSeasonId, string @namespace);

    /// <summary>
    ///     Gets an index of PvP rewards for a PvP season.
    /// </summary>
    /// <param name="pvpSeasonId">The ID of the PvP season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     An index of PvP rewards for a PvP season.
    /// </returns>
    Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpSeasonId, string @namespace, Region region, Locale locale);
}
