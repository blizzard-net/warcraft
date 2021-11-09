namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Mount API.
/// </summary>
public interface IMountApi
{
    /// <summary>
    ///     Gets an index of mounts.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The mount index.
    /// </returns>
    Task<RequestResult<MountsIndex>> GetMountsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of mounts.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The mount index.
    /// </returns>
    Task<RequestResult<MountsIndex>> GetMountsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified mount.
    /// </summary>
    /// <param name="mountId">The mount ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified mount.
    /// </returns>
    Task<RequestResult<Mount>> GetMountAsync(int mountId, string @namespace);

    /// <summary>
    ///     Get the specified mount.
    /// </summary>
    /// <param name="mountId">The mount ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified mount.
    /// </returns>
    Task<RequestResult<Mount>> GetMountAsync(int mountId, string @namespace, Region region, Locale locale);
}
