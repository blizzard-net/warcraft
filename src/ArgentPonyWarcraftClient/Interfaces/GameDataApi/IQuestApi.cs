namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Quest API.
/// </summary>
public interface IQuestApi
{
    /// <summary>
    ///     Gets an index of quests.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The quest index.
    /// </returns>
    Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of quests.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The quest index.
    /// </returns>
    Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified quest.
    /// </summary>
    /// <param name="questId">The quest ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified quest.
    /// </returns>
    Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace);

    /// <summary>
    ///     Get the specified quest.
    /// </summary>
    /// <param name="questId">The quest ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified quest.
    /// </returns>
    Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of quest categories.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The quest categories index.
    /// </returns>
    Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of quest categories.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The quest categories index.
    /// </returns>
    Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified quest category.
    /// </summary>
    /// <param name="questCategoryId">The quest category ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified quest category.
    /// </returns>
    Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace);

    /// <summary>
    ///     Get the specified quest category.
    /// </summary>
    /// <param name="questCategoryId">The quest category ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified quest category.
    /// </returns>
    Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of quest areas.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The quest areas index.
    /// </returns>
    Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of quest areas.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The quest areas index.
    /// </returns>
    Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified quest area.
    /// </summary>
    /// <param name="questAreaId">The quest area ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified quest area.
    /// </returns>
    Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace);

    /// <summary>
    ///     Get the specified quest area.
    /// </summary>
    /// <param name="questAreaId">The quest area ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified quest area.
    /// </returns>
    Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of quest types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The quest types index.
    /// </returns>
    Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of quest types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The quest types index.
    /// </returns>
    Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified quest type.
    /// </summary>
    /// <param name="questTypeId">The quest type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified quest type.
    /// </returns>
    Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace);

    /// <summary>
    ///     Get the specified quest type.
    /// </summary>
    /// <param name="questTypeId">The quest type ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified quest type.
    /// </returns>
    Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace, Region region, Locale locale);
}
