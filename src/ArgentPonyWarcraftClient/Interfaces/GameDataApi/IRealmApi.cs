namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Realm API.
/// </summary>
public interface IRealmApi
{
    /// <summary>
    ///     Gets an index of realms.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The realms index.
    /// </returns>
    Task<RequestResult<RealmsIndex>> GetRealmsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of realms.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The realms index.
    /// </returns>
    Task<RequestResult<RealmsIndex>> GetRealmsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified realm.
    /// </summary>
    /// <param name="realmSlug">The realm slug.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified realm.
    /// </returns>
    Task<RequestResult<Realm>> GetRealmAsync(string realmSlug, string @namespace);

    /// <summary>
    ///     Get the specified realm.
    /// </summary>
    /// <param name="realmSlug">The realm slug.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified realm.
    /// </returns>
    Task<RequestResult<Realm>> GetRealmAsync(string realmSlug, string @namespace, Region region, Locale locale);
}
