namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Mythic Keystone Dungeon API.
/// </summary>
public interface IMythicKeystoneDungeonApi
{
    /// <summary>
    ///     Gets an index of mythic keystone dungeons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of mythic keystone dungeons.
    /// </returns>
    Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of mythic keystone dungeons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of mythic keystone dungeons.
    /// </returns>
    Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified mythic keystone dungeon.
    /// </summary>
    /// <param name="dungeonId">The ID of the dungeon.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified mythic keystone dungeon.
    /// </returns>
    Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace);

    /// <summary>
    ///     Get the specified mythic keystone dungeon.
    /// </summary>
    /// <param name="dungeonId">The ID of the dungeon.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified mythic keystone dungeon.
    /// </returns>
    Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of links to other documents related to Mythic Keystone dungeons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of links to other documents related to Mythic Keystone dungeons.
    /// </returns>
    Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of links to other documents related to Mythic Keystone dungeons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of links to other documents related to Mythic Keystone dungeons.
    /// </returns>
    Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of mythic keystone periods.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of mythic keystone periods.
    /// </returns>
    Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of mythic keystone periods.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of mythic keystone periods.
    /// </returns>
    Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified mythic keystone period.
    /// </summary>
    /// <param name="periodId">The ID of the period.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified mythic keystone period.
    /// </returns>
    Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace);

    /// <summary>
    ///     Get the specified mythic keystone period.
    /// </summary>
    /// <param name="periodId">The ID of the period.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified mythic keystone period.
    /// </returns>
    Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of mythic keystone seasons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of mythic keystone seasons.
    /// </returns>
    Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of mythic keystone seasons.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of mythic keystone seasons.
    /// </returns>
    Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified mythic keystone season.
    /// </summary>
    /// <param name="seasonId">The ID of the Mythic Keystone season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified mythic keystone season.
    /// </returns>
    Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace);

    /// <summary>
    ///     Get the specified mythic keystone season.
    /// </summary>
    /// <param name="seasonId">The ID of the Mythic Keystone season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified mythic keystone season.
    /// </returns>
    Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace, Region region, Locale locale);
}
