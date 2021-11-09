namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Encounters API.
/// </summary>
public interface ICharacterEncountersApi
{
    /// <summary>
    ///     Get a summary of a character's encounters.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of a character's encounters.
    /// </returns>
    Task<RequestResult<CharacterEncountersSummary>> GetCharacterEncountersSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a summary of a character's encounters.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of a character's encounters.
    /// </returns>
    Task<RequestResult<CharacterEncountersSummary>> GetCharacterEncountersSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a summary of a character's completed dungeons.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of a character's completed dungeons.
    /// </returns>
    Task<RequestResult<CharacterDungeons>> GetCharacterDungeonsAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a summary of a character's completed dungeons.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of a character's completed dungeons.
    /// </returns>
    Task<RequestResult<CharacterDungeons>> GetCharacterDungeonsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a summary of a character's completed raids.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of a character's completed raids.
    /// </returns>
    Task<RequestResult<CharacterRaids>> GetCharacterRaidsAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a summary of a character's completed raids.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of a character's completed raids.
    /// </returns>
    Task<RequestResult<CharacterRaids>> GetCharacterRaidsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
