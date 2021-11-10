namespace ArgentPonyWarcraftClient;

/// <summary>
/// A client for retrieving tech talent data from the World of Warcraft Game Data APIs.
/// </summary>
public interface ITechTalentApi
{
    /// <summary>
    /// Gets an index of tech talent trees.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The index of tech talent trees.
    /// </returns>
    Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreesIndexAsync(string @namespace);

    /// <summary>
    /// Gets an index of tech talent trees.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The index of tech talent trees.
    /// </returns>
    Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets a tech talent tree by Id.
    /// </summary>
    /// <param name="techTalentTreeId">The Id of the tech talent tree.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The tech talent tree by Id.
    /// </returns>
    Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace);

    /// <summary>
    /// Gets a tech talent tree by Id.
    /// </summary>
    /// <param name="techTalentTreeId">The Id of the tech talent tree.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The tech talent tree by Id.
    /// </returns>
    Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets an index of the tech talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The index of the tech talents.
    /// </returns>
    Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace);

    /// <summary>
    /// Gets an index of the tech talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The index of the tech talents.
    /// </returns>
    Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets a tech talent by Id.
    /// </summary>
    /// <param name="techTalentId">The tech talent Id.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The tech talent.
    /// </returns>
    Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace);

    /// <summary>
    /// Gets a tech talent by Id.
    /// </summary>
    /// <param name="techTalentId">The tech talent Id.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The tech talent.
    /// </returns>
    Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace, Region region, Locale locale);

    /// <summary>
    /// Gets the media for a tech talent.
    /// </summary>
    /// <param name="techTalentId">The tech talent Id.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    /// The media for the tech talent Id.
    /// </returns>
    Task<RequestResult<TechTalentMedia>> GetTechTalentMediaAsync(int techTalentId, string @namespace);

    /// <summary>
    /// Gets the media for a tech talent.
    /// </summary>
    /// <param name="techTalentId">The tech talent Id.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language the result will be in.</param>
    /// <returns>
    /// The media for the tech talent Id.
    /// </returns>
    Task<RequestResult<TechTalentMedia>> GetTechTalentMediaAsync(int techTalentId, string @namespace, Region region, Locale locale);
}
