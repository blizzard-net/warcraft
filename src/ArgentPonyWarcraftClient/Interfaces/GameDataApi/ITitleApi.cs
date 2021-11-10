namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Title API.
/// </summary>
public interface ITitleApi
{
    /// <summary>
    ///     Gets an index of titles.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The title index.
    /// </returns>
    Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of titles.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The title index.
    /// </returns>
    Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified title.
    /// </summary>
    /// <param name="titleId">The title ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified title.
    /// </returns>
    Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace);

    /// <summary>
    ///     Get the specified title.
    /// </summary>
    /// <param name="titleId">The title ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified title.
    /// </returns>
    Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace, Region region, Locale locale);
}
