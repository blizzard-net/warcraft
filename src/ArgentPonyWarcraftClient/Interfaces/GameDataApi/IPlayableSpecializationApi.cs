namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Playable Specialization API.
/// </summary>
public interface IPlayableSpecializationApi
{
    /// <summary>
    ///     Gets an index of playable specializations.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The playable specializations index.
    /// </returns>
    Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of playable specializations.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The playable specializations index.
    /// </returns>
    Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified playable specialization.
    /// </summary>
    /// <param name="specId">The playable specialization ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified playable specialization.
    /// </returns>
    Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace);

    /// <summary>
    ///     Get the specified playable specialization.
    /// </summary>
    /// <param name="specId">The playable specialization ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified playable specialization.
    /// </returns>
    Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a playable specialization by ID.
    /// </summary>
    /// <param name="specId">The playable specialization ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a playable specialization by ID.
    /// </returns>
    Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace);

    /// <summary>
    ///     Get media for a playable specialization by ID.
    /// </summary>
    /// <param name="specId">The playable specialization ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a playable specialization by ID.
    /// </returns>
    Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace, Region region, Locale locale);
}
