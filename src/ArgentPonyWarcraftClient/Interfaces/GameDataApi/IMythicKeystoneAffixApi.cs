namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Mythic Keystone Affix API.
/// </summary>
public interface IMythicKeystoneAffixApi
{
    /// <summary>
    ///     Gets an index of mythic keystone affixes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of mythic keystone affixes.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffixesIndex>> GetMythicKeystoneAffixesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of mythic keystone affixes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of mythic keystone affixes.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffixesIndex>> GetMythicKeystoneAffixesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets the specified mythic keystone affix.
    /// </summary>
    /// <param name="keystoneAffixId">The ID of the mythic keystone affix.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified mythic keystone affix.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId, string @namespace);

    /// <summary>
    ///     Gets the specified mythic keystone affix.
    /// </summary>
    /// <param name="keystoneAffixId">The ID of the mythic keystone affix.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified mythic keystone affix.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a mythic keystone affix by ID.
    /// </summary>
    /// <param name="keystoneAffixId">The mythic keystone affix ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a mythic keystone affix by ID.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffixMedia>> GetMythicKeystoneAffixMediaAsync(int keystoneAffixId, string @namespace);

    /// <summary>
    ///     Get media for a mythic keystone affix by ID.
    /// </summary>
    /// <param name="keystoneAffixId">The mythic keystone affix ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a mythic keystone affix by ID.
    /// </returns>
    Task<RequestResult<MythicKeystoneAffixMedia>> GetMythicKeystoneAffixMediaAsync(int keystoneAffixId, string @namespace, Region region, Locale locale);
}
