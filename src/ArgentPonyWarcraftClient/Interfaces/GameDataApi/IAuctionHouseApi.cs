namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Auction House API.
/// </summary>
public interface IAuctionHouseApi
{
    /// <summary>
    ///     Gets an index of auctions.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The auctions index.
    /// </returns>
    Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace);

    /// <summary>
    ///     Gets an index of auctions.
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The auctions index.
    /// </returns>
    Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of commodities.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The commodities index.
    /// </returns>
    Task<RequestResult<CommoditiesIndex>> GetCommoditiesAsync(string @namespace);

    /// <summary>
    ///     Gets an index of commodities.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The commodities index.
    /// </returns>
    Task<RequestResult<CommoditiesIndex>> GetCommoditiesAsync(string @namespace, Region region, Locale locale);
}
