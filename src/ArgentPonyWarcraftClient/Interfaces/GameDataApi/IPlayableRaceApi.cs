namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Playable Race API.
/// </summary>
public interface IPlayableRaceApi
{
    /// <summary>
    ///     Gets an index of playable races.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The playable races index.
    /// </returns>
    Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of playable races.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The playable races index.
    /// </returns>
    Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified playable race.
    /// </summary>
    /// <param name="playableRaceId">The playable race ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified playable race.
    /// </returns>
    Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace);

    /// <summary>
    ///     Get the specified playable race.
    /// </summary>
    /// <param name="playableRaceId">The playable race ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified playable race.
    /// </returns>
    Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace, Region region, Locale locale);
}
