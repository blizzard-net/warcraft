namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Playable Class API.
/// </summary>
public interface IPlayableClassApi
{
    /// <summary>
    ///     Gets an index of playable classes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The playable classes index.
    /// </returns>
    Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of playable classes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The playable classes index.
    /// </returns>
    Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified playable class.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified playable class.
    /// </returns>
    Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace);

    /// <summary>
    ///     Get the specified playable class.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified playable class.
    /// </returns>
    Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a playable class by ID.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a playable class by ID.
    /// </returns>
    Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace);

    /// <summary>
    ///     Get media for a playable class by ID.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a playable class by ID.
    /// </returns>
    Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the PvP talent slots for the specified playable class.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP talent slots for the specified playable class.
    /// </returns>
    Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace);

    /// <summary>
    ///     Get the PvP talent slots for the specified playable class.
    /// </summary>
    /// <param name="classId">The playable class ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP talent slots for the specified playable class.
    /// </returns>
    Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace, Region region, Locale locale);
}
