namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Power Type API.
/// </summary>
public interface IPowerTypeApi
{
    /// <summary>
    ///     Gets an index of power types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of power types.
    /// </returns>
    Task<RequestResult<PowerTypesIndex>> GetPowerTypesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of power types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of power types.
    /// </returns>
    Task<RequestResult<PowerTypesIndex>> GetPowerTypesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified power type.
    /// </summary>
    /// <param name="powerTypeId">The power type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified power type.
    /// </returns>
    Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId, string @namespace);

    /// <summary>
    ///     Get the specified power type.
    /// </summary>
    /// <param name="powerTypeId">The power type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified power type.
    /// </returns>
    Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId, string @namespace, Region region, Locale locale);
}
