﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Titles API.
/// </summary>
public interface ICharacterTitlesApi
{
    /// <summary>
    ///     Get a summary of titles a character has obtained.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     A summary of titles the character has obtained.
    /// </returns>
    Task<RequestResult<CharacterTitlesSummary>> GetCharacterTitlesSummaryAsync(string realmSlug, string characterName, string @namespace);

    /// <summary>
    ///     Get a summary of titles a character has obtained.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     A summary of titles the character has obtained.
    /// </returns>
    Task<RequestResult<CharacterTitlesSummary>> GetCharacterTitlesSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale);
}
