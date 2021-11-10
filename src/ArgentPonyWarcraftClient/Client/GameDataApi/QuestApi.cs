namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace)
    {
        return await GetQuestsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestsIndex>($"{host}/data/wow/quest/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace)
    {
        return await GetQuestAsync(questId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Quest>($"{host}/data/wow/quest/{questId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace)
    {
        return await GetQuestCategoriesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestCategoriesIndex>($"{host}/data/wow/quest/category/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace)
    {
        return await GetQuestCategoryAsync(questCategoryId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestCategory>($"{host}/data/wow/quest/category/{questCategoryId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace)
    {
        return await GetQuestAreasIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestAreasIndex>($"{host}/data/wow/quest/area/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace)
    {
        return await GetQuestAreaAsync(questAreaId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestArea>($"{host}/data/wow/quest/area/{questAreaId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace)
    {
        return await GetQuestTypesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestTypesIndex>($"{host}/data/wow/quest/type/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace)
    {
        return await GetQuestTypeAsync(questTypeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<QuestType>($"{host}/data/wow/quest/type/{questTypeId}?namespace={@namespace}&locale={locale}");
    }
}
