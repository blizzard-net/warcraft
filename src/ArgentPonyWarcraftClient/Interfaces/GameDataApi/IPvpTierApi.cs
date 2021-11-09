namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft PvP Tier API.
/// </summary>
public interface IPvpTierApi
{
    /// <summary>
    ///     Gets an index of PvP tiers.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP tier index.
    /// </returns>
    Task<RequestResult<PvpTiersIndex>> GetPvpTiersIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of PvP tiers.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP tier index.
    /// </returns>
    Task<RequestResult<PvpTiersIndex>> GetPvpTiersIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified PvP tier.
    /// </summary>
    /// <param name="pvpTierId">The PvP tier ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified PvP tier.
    /// </returns>
    Task<RequestResult<PvpTier>> GetPvpTierAsync(int pvpTierId, string @namespace);

    /// <summary>
    ///     Get the specified PvP tier.
    /// </summary>
    /// <param name="pvpTierId">The PvP tier ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified PvP tier.
    /// </returns>
    Task<RequestResult<PvpTier>> GetPvpTierAsync(int pvpTierId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a PvP tier by ID.
    /// </summary>
    /// <param name="pvpTierId">The PvP tier ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a PvP tier by ID.
    /// </returns>
    Task<RequestResult<PvpTierMedia>> GetPvpTierMediaAsync(int pvpTierId, string @namespace);

    /// <summary>
    ///     Get media for a PvP tier by ID.
    /// </summary>
    /// <param name="pvpTierId">The PvP tier ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a PvP tier by ID.
    /// </returns>
    Task<RequestResult<PvpTierMedia>> GetPvpTierMediaAsync(int pvpTierId, string @namespace, Region region, Locale locale);
}
