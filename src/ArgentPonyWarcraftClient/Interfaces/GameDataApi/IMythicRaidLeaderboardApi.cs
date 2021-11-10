namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Mythic Raid Leaderboard API.
/// </summary>
public interface IMythicRaidLeaderboardApi
{
    /// <summary>
    ///     Gets the leaderboard for a given raid and faction.
    /// </summary>
    /// <param name="raid">The raid for a leaderboard.</param>
    /// <param name="faction">The player faction ("alliance" or "horde").</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The leaderboard for a given raid and faction.
    /// </returns>
    Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace);

    /// <summary>
    ///     Gets the leaderboard for a given raid and faction.
    /// </summary>
    /// <param name="raid">The raid for a leaderboard.</param>
    /// <param name="faction">The player faction ("alliance" or "horde").</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The leaderboard for a given raid and faction.
    /// </returns>
    Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace, Region region, Locale locale);
}
