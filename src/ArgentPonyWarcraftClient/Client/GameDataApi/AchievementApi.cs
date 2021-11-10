namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace)
    {
        return await GetAchievementCategoriesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AchievementCategoriesIndex>($"{host}/data/wow/achievement-category/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace)
    {
        return await GetAchievementCategoryAsync(achievementCategoryId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AchievementCategory>($"{host}/data/wow/achievement-category/{achievementCategoryId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace)
    {
        return await GetAchievementsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AchievementsIndex>($"{host}/data/wow/achievement/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace)
    {
        return await GetAchievementAsync(achievementId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Achievement>($"{host}/data/wow/achievement/{achievementId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace)
    {
        return await GetAchievementMediaAsync(achievementId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AchievementMedia>($"{host}/data/wow/media/achievement/{achievementId}?namespace={@namespace}&locale={locale}");
    }
}
