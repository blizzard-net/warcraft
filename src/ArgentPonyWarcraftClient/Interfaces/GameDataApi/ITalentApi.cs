namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Talent API.
/// </summary>
public interface ITalentApi
{
    /// <summary>
    ///     Gets an index of talent trees.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The talent tree index.
    /// </returns>
    Task<RequestResult<TalentTreeIndex>> GetTalentTreeIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of talent trees.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The talent tree index.
    /// </returns>
    Task<RequestResult<TalentTreeIndex>> GetTalentTreeIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified talent tree by specialization ID.
    /// </summary>
    /// <param name="talentTreeId">The ID of the talent tree.</param>
    /// <param name="specId">The ID of the playable specialization.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified talent tree by specialization ID.
    /// </returns>
    Task<RequestResult<TalentTree>> GetTalentTreeAsync(int talentTreeId, int specId, string @namespace);

    /// <summary>
    ///     Get the specified talent tree by specialization ID.
    /// </summary>
    /// <param name="talentTreeId">The ID of the talent tree.</param>
    /// <param name="specId">The ID of the playable specialization.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified talent tree by specialization ID.
    /// </returns>
    Task<RequestResult<TalentTree>> GetTalentTreeAsync(int talentTreeId, int specId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get all talent tree nodes as well as links to associated playable specializations given a talent tree ID.
    /// </summary>
    /// <param name="talentTreeId">The ID of the talent tree.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     All talent tree nodes as well as links to associated playable specializations given a talent tree ID.
    /// </returns>
    /// <remarks>
    ///     This is useful to generate loadout export codes.
    /// </remarks>
    Task<RequestResult<TalentTreeNodes>> GetTalentTreeNodesAsync(int talentTreeId, string @namespace);

    /// <summary>
    ///     Get all talent tree nodes as well as links to associated playable specializations given a talent tree ID.
    /// </summary>
    /// <param name="talentTreeId">The ID of the talent tree.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     All talent tree nodes as well as links to associated playable specializations given a talent tree ID.
    /// </returns>
    /// <remarks>
    ///     This is useful to generate loadout export codes.
    /// </remarks>
    Task<RequestResult<TalentTreeNodes>> GetTalentTreeNodesAsync(int talentTreeId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The talent index.
    /// </returns>
    Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The talent index.
    /// </returns>
    Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified talent.
    /// </summary>
    /// <param name="talentId">The talent ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified talent.
    /// </returns>
    Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace);

    /// <summary>
    ///     Get the specified talent.
    /// </summary>
    /// <param name="talentId">The talent ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified talent.
    /// </returns>
    Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of PvP talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The PvP talent index.
    /// </returns>
    Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of PvP talents.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The PvP talent index.
    /// </returns>
    Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified PvP talent.
    /// </summary>
    /// <param name="pvpTalentId">The PvP talent ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified PvP talent.
    /// </returns>
    Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace);

    /// <summary>
    ///     Get the specified PvP talent.
    /// </summary>
    /// <param name="pvpTalentId">The PvP talent ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified PvP talent.
    /// </returns>
    Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace, Region region, Locale locale);
}
