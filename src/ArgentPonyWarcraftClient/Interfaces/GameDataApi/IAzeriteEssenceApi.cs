namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Azerite Essence API.
/// </summary>
public interface IAzeriteEssenceApi
{
    /// <summary>
    ///     Gets an index of azerite essences.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of azerite essences.
    /// </returns>
    Task<RequestResult<AzeriteEssencesIndex>> GetAzeriteEssencesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of azerite essences.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of azerite essences.
    /// </returns>
    Task<RequestResult<AzeriteEssencesIndex>> GetAzeriteEssencesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified azerite essence.
    /// </summary>
    /// <param name="azeriteEssenceId">The azerite essence ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified azerite essence.
    /// </returns>
    Task<RequestResult<AzeriteEssence>> GetAzeriteEssenceAsync(int azeriteEssenceId, string @namespace);

    /// <summary>
    ///     Get the specified azerite essence.
    /// </summary>
    /// <param name="azeriteEssenceId">The azerite essence ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified azerite essence.
    /// </returns>
    Task<RequestResult<AzeriteEssence>> GetAzeriteEssenceAsync(int azeriteEssenceId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for an azerite essence by ID.
    /// </summary>
    /// <param name="azeriteEssenceId">The azerite essence ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for an azerite essence.
    /// </returns>
    Task<RequestResult<AzeriteEssenceMedia>> GetAzeriteEssenceMediaAsync(int azeriteEssenceId, string @namespace);

    /// <summary>
    ///     Get media for an azerite essence by ID.
    /// </summary>
    /// <param name="azeriteEssenceId">The azerite essence ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for an azerite essence.
    /// </returns>
    Task<RequestResult<AzeriteEssenceMedia>> GetAzeriteEssenceMediaAsync(int azeriteEssenceId, string @namespace, Region region, Locale locale);
}
