namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Game Data APIs.
/// </summary>
public interface IAchievementApi
{
    /// <summary>
    ///     Get the achievement categories index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The achievement categories index.
    /// </returns>
    Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace);

    /// <summary>
    ///     Get the achievement categories index.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The achievement categories index.
    /// </returns>
    Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified achievement category.
    /// </summary>
    /// <param name="achievementCategoryId">The achievement category ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified achievement category.
    /// </returns>
    Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace);

    /// <summary>
    ///     Get the specified achievement category.
    /// </summary>
    /// <param name="achievementCategoryId">The achievement category ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified achievement category.
    /// </returns>
    Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of achievements.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The achievement index.
    /// </returns>
    Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of achievements.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The achievement index.
    /// </returns>
    Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified achievement.
    /// </summary>
    /// <param name="achievementId">The achievement ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified achievement.
    /// </returns>
    Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace);

    /// <summary>
    ///     Get the specified achievement.
    /// </summary>
    /// <param name="achievementId">The achievement ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified achievement.
    /// </returns>
    Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for an achievement by ID.
    /// </summary>
    /// <param name="achievementId">The achievement ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for an achievement by ID.
    /// </returns>
    Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace);

    /// <summary>
    ///     Get media for an achievement by ID.
    /// </summary>
    /// <param name="achievementId">The achievement ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for an achievement by ID.
    /// </returns>
    Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace, Region region, Locale locale);
}
