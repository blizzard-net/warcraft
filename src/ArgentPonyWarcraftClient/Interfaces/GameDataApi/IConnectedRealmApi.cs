namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Connected Realm API.
/// </summary>
public interface IConnectedRealmApi
{
    /// <summary>
    ///     Gets an index of connected realms.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The connected realms index.
    /// </returns>
    Task<RequestResult<ConnectedRealmsIndex>> GetConnectedRealmsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of connected realms.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The connected realms index.
    /// </returns>
    Task<RequestResult<ConnectedRealmsIndex>> GetConnectedRealmsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified connected realm.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified connected realm.
    /// </returns>
    Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId, string @namespace);

    /// <summary>
    ///     Get the specified connected realm.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified connected realm.
    /// </returns>
    Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId, string @namespace, Region region, Locale locale);
}
