namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Mythic Keystone Leaderboard API.
/// </summary>
public interface IMythicKeystoneLeaderboardApi
{
    /// <summary>
    ///     Gets an index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </returns>
    Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace);

    /// <summary>
    ///     Gets an index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </returns>
    Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets a Mythic Keystone Leaderboard by period.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="dungeonId">The ID of the dungeon.</param>
    /// <param name="period">The unique identifier for the leaderboard period.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A Mythic Keystone Leaderboard for a period.
    /// </returns>
    Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace);

    /// <summary>
    ///     Gets a Mythic Keystone Leaderboard by period.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="dungeonId">The ID of the dungeon.</param>
    /// <param name="period">The unique identifier for the leaderboard period.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A Mythic Keystone Leaderboard for a period.
    /// </returns>
    Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace, Region region, Locale locale);
}
