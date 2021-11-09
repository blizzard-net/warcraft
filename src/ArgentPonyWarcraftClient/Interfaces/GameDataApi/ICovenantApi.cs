namespace ArgentPonyWarcraftClient;

/// <summary>
/// A client for retrieving covenant data from the World of Warcraft Game Data APIs.
/// </summary>
public interface ICovenantApi
{
    /// <summary>
    /// Gets an index of covenants.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The index of covenants.
    /// </returns>
    Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace);

    /// <summary>
    /// Gets an index of covenants.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The index of covenants.
    /// </returns>
    Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets a covenant by Id.
    /// </summary>
    /// <param name="covenantId">The Id of the covenant.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The covenant.
    /// </returns>
    Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace);

    /// <summary>
    /// Gets a covenant by Id.
    /// </summary>
    /// <param name="covenantId">The Id of the covenant.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The covenant.
    /// </returns>
    Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets media for a covenant by the covenant Id.
    /// </summary>
    /// <param name="covenantId">The Id of the covenant.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// Media for a covenant.
    /// </returns>
    Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace);

    /// <summary>
    /// Gets media for a covenant by the covenant Id.
    /// </summary>
    /// <param name="covenantId">The Id of the covenant.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// Media for a covenant.
    /// </returns>
    Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets an index of soulbinds.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The index of soulbinds.
    /// </returns>
    Task<RequestResult<SoulbindsIndex>> GetSoulbindsIndexAsync(string @namespace);

    /// <summary>
    /// Gets an index of soulbinds.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The index of soulbinds.
    /// </returns>
    Task<RequestResult<SoulbindsIndex>> GetSoulbindsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets a soulbind by Id.
    /// </summary>
    /// <param name="soulbindId">The Id of the soulbind to retrieve.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The soulbind.
    /// </returns>
    Task<RequestResult<Soulbind>> GetSoulbindAsync(int soulbindId, string @namespace);

    /// <summary>
    /// Gets a soulbind by Id.
    /// </summary>
    /// <param name="soulbindId">The Id of the soulbind to retrieve.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The soulbind.
    /// </returns>
    Task<RequestResult<Soulbind>> GetSoulbindAsync(int soulbindId, string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets an index of conduits.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The index of conduits.
    /// </returns>
    Task<RequestResult<ConduitsIndex>> GetConduitsIndexAsync(string @namespace);

    /// <summary>
    /// Gets an index of conduits.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The index of conduits.
    /// </returns>
    Task<RequestResult<ConduitsIndex>> GetConduitsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets a conduit by Id.
    /// </summary>
    /// <param name="conduitId">The Id of the conduit to retrieve.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The conduit.
    /// </returns>
    Task<RequestResult<Conduit>> GetConduitAsync(int conduitId, string @namespace);

    /// <summary>
    /// Gets a conduit by Id.
    /// </summary>
    /// <param name="conduitId">The Id of the conduit to retrieve.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The conduit.
    /// </returns>
    Task<RequestResult<Conduit>> GetConduitAsync(int conduitId, string @namespace, Region region, Locale locale);
}
