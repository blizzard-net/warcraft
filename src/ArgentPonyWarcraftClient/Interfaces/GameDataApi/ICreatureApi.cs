namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Creature API.
/// </summary>
public interface ICreatureApi
{
    /// <summary>
    ///     Gets an index of creature families.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The creature families index.
    /// </returns>
    Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of creature families.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The creature families index.
    /// </returns>
    Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified creature family.
    /// </summary>
    /// <param name="creatureFamilyId">The creature family ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified creature family.
    /// </returns>
    Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace);

    /// <summary>
    ///     Get the specified creature family.
    /// </summary>
    /// <param name="creatureFamilyId">The creature family ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified creature family.
    /// </returns>
    Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of creature types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The creature families types.
    /// </returns>
    Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of creature types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The creature families types.
    /// </returns>
    Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified creature type.
    /// </summary>
    /// <param name="creatureTypeId">The creature type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified creature type.
    /// </returns>
    Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace);

    /// <summary>
    ///     Get the specified creature type.
    /// </summary>
    /// <param name="creatureTypeId">The creature type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified creature type.
    /// </returns>
    Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified creature.
    /// </summary>
    /// <param name="creatureId">The creature ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified creature.
    /// </returns>
    Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace);

    /// <summary>
    ///     Get the specified creature.
    /// </summary>
    /// <param name="creatureId">The creature ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified creature.
    /// </returns>
    Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified creature display media.
    /// </summary>
    /// <param name="creatureDisplayId">The creature display ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified creature display media.
    /// </returns>
    Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace);

    /// <summary>
    ///     Get the specified creature display media.
    /// </summary>
    /// <param name="creatureDisplayId">The creature display ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified creature display media.
    /// </returns>
    Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified creature family media.
    /// </summary>
    /// <param name="creatureFamilyId">The creature family ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified creature family media.
    /// </returns>
    Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace);

    /// <summary>
    ///     Get the specified creature family media.
    /// </summary>
    /// <param name="creatureFamilyId">The creature family ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified creature family media.
    /// </returns>
    Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace, Region region, Locale locale);
}
