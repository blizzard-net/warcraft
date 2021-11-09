namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft WoW Token API.
/// </summary>
public interface IWowTokenApi
{
    /// <summary>
    ///     Gets the WoW Token index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The WoW Token index.
    /// </returns>
    Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace);

    /// <summary>
    ///     Gets the WoW Token index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The WoW Token index.
    /// </returns>
    Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace, Region region, Locale locale);
}
