namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Reputations API.
/// </summary>
public interface IReputationsApi
{
    /// <summary>
    ///     Gets an index of reputation factions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The reputation faction index.
    /// </returns>
    Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of reputation factions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The reputation faction index.
    /// </returns>
    Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified reputation faction.
    /// </summary>
    /// <param name="reputationFactionId">The reputation faction ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified reputation faction.
    /// </returns>
    Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace);

    /// <summary>
    ///     Get the specified reputation faction.
    /// </summary>
    /// <param name="reputationFactionId">The reputation faction ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified reputation faction.
    /// </returns>
    Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of reputation tiers.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The reputation tiers index.
    /// </returns>
    Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of reputation tiers.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The reputation tiers index.
    /// </returns>
    Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified set of reputation tiers.
    /// </summary>
    /// <param name="reputationTiersId">The ID of the set of reputation tiers.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified set of reputation tiers.
    /// </returns>
    Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace);

    /// <summary>
    ///     Get the specified set of reputation tiers.
    /// </summary>
    /// <param name="reputationTiersId">The ID of the set of reputation tiers.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified set of reputation tiers.
    /// </returns>
    Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace, Region region, Locale locale);
}
