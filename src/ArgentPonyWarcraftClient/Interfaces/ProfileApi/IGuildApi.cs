namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Character Guild API.
/// </summary>
public interface IGuildApi
{
    /// <summary>
    ///     Get the specified guild.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified guild.
    /// </returns>
    Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace);

    /// <summary>
    ///     Get the specified guild.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified guild.
    /// </returns>
    Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified guild's activity.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified guild's activity.
    /// </returns>
    Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace);

    /// <summary>
    ///     Get the specified guild's activity.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified guild's activity.
    /// </returns>
    Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified guild's achievements.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified guild's achievements.
    /// </returns>
    Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace);

    /// <summary>
    ///     Get the specified guild's achievements.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified guild's achievements.
    /// </returns>
    Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified guild's roster.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified guild's roster.
    /// </returns>
    Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace);

    /// <summary>
    ///     Get the specified guild's roster.
    /// </summary>
    /// <param name="realmSlug">The slug of the realm.</param>
    /// <param name="nameSlug">The slug of the guild.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified guild's roster.
    /// </returns>
    Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale);
}
