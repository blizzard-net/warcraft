namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Guild Crest API.
/// </summary>
public interface IGuildCrestApi
{
    /// <summary>
    ///     Gets an index of guild crest media.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of guild crest media.
    /// </returns>
    Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of guild crest media.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of guild crest media.
    /// </returns>
    Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a guild crest border by ID.
    /// </summary>
    /// <param name="borderId">The guild crest border ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a guild crest border by ID.
    /// </returns>
    Task<RequestResult<GuildCrestBorderMedia>> GetGuildCrestBorderMediaAsync(int borderId, string @namespace);

    /// <summary>
    ///     Get media for a guild crest border by ID.
    /// </summary>
    /// <param name="borderId">The guild crest border ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a guild crest border by ID.
    /// </returns>
    Task<RequestResult<GuildCrestBorderMedia>> GetGuildCrestBorderMediaAsync(int borderId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a guild crest emblem by ID.
    /// </summary>
    /// <param name="emblemId">The guild crest emblem ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a guild crest emblem by ID.
    /// </returns>
    Task<RequestResult<GuildCrestEmblemMedia>> GetGuildCrestEmblemMediaAsync(int emblemId, string @namespace);

    /// <summary>
    ///     Get media for a guild crest emblem by ID.
    /// </summary>
    /// <param name="emblemId">The guild crest emblem ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a guild crest emblem by ID.
    /// </returns>
    Task<RequestResult<GuildCrestEmblemMedia>> GetGuildCrestEmblemMediaAsync(int emblemId, string @namespace, Region region, Locale locale);
}
