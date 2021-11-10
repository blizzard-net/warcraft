namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Mythic Keystone Profile API.
/// </summary>
public interface ICharacterMythicKeystoneProfileApi
{
    /// <summary>
    ///     Get the specified Mythic Keystone profile index for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified Mythic Keystone profile index for a character.
    /// </returns>
    Task<RequestResult<CharacterMythicKeystoneProfileIndex>> GetCharacterMythicKeystoneProfileIndexAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get the specified Mythic Keystone profile index for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified Mythic Keystone profile index for a character.
    /// </returns>
    Task<RequestResult<CharacterMythicKeystoneProfileIndex>> GetCharacterMythicKeystoneProfileIndexAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the Mythic Keystone season details for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="seasonId">The ID of the Mythic Keystone season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The Mythic Keystone season details for a character.
    /// </returns>
    Task<RequestResult<CharacterMythicKeystoneSeasonDetails>> GetCharacterMythicKeystoneSeasonDetailsAsync(string realmSlug, string characterName, int seasonId, string @namespace);

    /// <summary>
    ///     Get the Mythic Keystone season details for a character.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="seasonId">The ID of the Mythic Keystone season.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The Mythic Keystone season details for a character.
    /// </returns>
    Task<RequestResult<CharacterMythicKeystoneSeasonDetails>> GetCharacterMythicKeystoneSeasonDetailsAsync(string realmSlug, string characterName, int seasonId, string @namespace, Region region, Locale locale);
}
