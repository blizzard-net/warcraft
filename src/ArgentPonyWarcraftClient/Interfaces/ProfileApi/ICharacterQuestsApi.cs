namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Quests API.
/// </summary>
public interface ICharacterQuestsApi
{
    /// <summary>
    ///     Get a character's active quests as well as a link to the character's completed quests.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The character's active quests as well as a link to the character's completed quests.
    /// </returns>
    Task<RequestResult<CharacterQuests>> GetCharacterQuestsAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a character's active quests as well as a link to the character's completed quests.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The character's active quests as well as a link to the character's completed quests.
    /// </returns>
    Task<RequestResult<CharacterQuests>> GetCharacterQuestsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get a list of quests that a character has completed.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The list of quests that a character has completed.
    /// </returns>
    Task<RequestResult<CharacterCompletedQuests>> GetCharacterCompletedQuestsAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a list of quests that a character has completed.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The list of quests that a character has completed.
    /// </returns>
    Task<RequestResult<CharacterCompletedQuests>> GetCharacterCompletedQuestsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
