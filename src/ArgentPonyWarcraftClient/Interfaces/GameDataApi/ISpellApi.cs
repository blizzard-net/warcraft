namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Spell API.
/// </summary>
public interface ISpellApi
{
    /// <summary>
    ///     Get the specified spell.
    /// </summary>
    /// <param name="spellId">The spell ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified spell.
    /// </returns>
    Task<RequestResult<Spell>> GetSpellAsync(int spellId, string @namespace);

    /// <summary>
    ///     Get the specified spell.
    /// </summary>
    /// <param name="spellId">The spell ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified spell.
    /// </returns>
    Task<RequestResult<Spell>> GetSpellAsync(int spellId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a spell by ID.
    /// </summary>
    /// <param name="spellId">The spell ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a spell by ID.
    /// </returns>
    Task<RequestResult<SpellMedia>> GetSpellMediaAsync(int spellId, string @namespace);

    /// <summary>
    ///     Get media for a spell by ID.
    /// </summary>
    /// <param name="spellId">The spell ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a spell by ID.
    /// </returns>
    Task<RequestResult<SpellMedia>> GetSpellMediaAsync(int spellId, string @namespace, Region region, Locale locale);
}
