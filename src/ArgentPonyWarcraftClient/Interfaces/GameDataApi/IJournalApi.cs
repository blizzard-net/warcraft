namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Journal API.
/// </summary>
public interface IJournalApi
{
    /// <summary>
    ///     Get the journal expansions index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The journal expansions index.
    /// </returns>
    Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace);

    /// <summary>
    ///     Get the journal expansions index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The journal expansions index.
    /// </returns>
    Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified expansion.
    /// </summary>
    /// <param name="journalExpansionId">The journal expansion ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified expansion.
    /// </returns>
    Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace);

    /// <summary>
    ///     Get the specified expansion.
    /// </summary>
    /// <param name="journalExpansionId">The journal expansion ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified expansion.
    /// </returns>
    Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the journal encounters index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The journal encounters index.
    /// </returns>
    Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace);

    /// <summary>
    ///     Get the journal encounters index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The journal encounters index.
    /// </returns>
    Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified encounter.
    /// </summary>
    /// <param name="journalEncounterId">The journal encounter ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified encounter.
    /// </returns>
    Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace);

    /// <summary>
    ///     Get the specified encounter.
    /// </summary>
    /// <param name="journalEncounterId">The journal encounter ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified encounter.
    /// </returns>
    Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the journal instances index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The journal instances index.
    /// </returns>
    Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace);

    /// <summary>
    ///     Get the journal instances index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The journal instances index.
    /// </returns>
    Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified dungeon or raid instance.
    /// </summary>
    /// <param name="journalInstanceId">The journal instance ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified dungeon or raid instance.
    /// </returns>
    Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace);

    /// <summary>
    ///     Get the specified dungeon or raid instance.
    /// </summary>
    /// <param name="journalInstanceId">The journal instance ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified dungeon or raid instance.
    /// </returns>
    Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a journal instance by ID.
    /// </summary>
    /// <param name="journalInstanceId">The journal instance ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a journal instance by ID.
    /// </returns>
    Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace);

    /// <summary>
    ///     Get media for a journal instance by ID.
    /// </summary>
    /// <param name="journalInstanceId">The journal instance ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a journal instance by ID.
    /// </returns>
    Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace, Region region, Locale locale);
}
