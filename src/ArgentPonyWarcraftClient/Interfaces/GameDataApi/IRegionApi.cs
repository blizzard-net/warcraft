namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Region API.
/// </summary>
public interface IRegionApi
{
    /// <summary>
    ///     Gets an index of regions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of regions.
    /// </returns>
    Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of regions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of regions.
    /// </returns>
    Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified region.
    /// </summary>
    /// <param name="regionId">The region ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified region.
    /// </returns>
    Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace);

    /// <summary>
    ///     Get the specified region.
    /// </summary>
    /// <param name="regionId">The region ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified region.
    /// </returns>
    Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace, Region region, Locale locale);
}
