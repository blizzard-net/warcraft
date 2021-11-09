namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterAchievementsSummary>> GetCharacterAchievementsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterAchievementsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterAchievementsSummary>> GetCharacterAchievementsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterAchievementsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/achievements?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterAchievementStatistics>> GetCharacterAchievementStatisticsAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterAchievementStatisticsAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterAchievementStatistics>> GetCharacterAchievementStatisticsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterAchievementStatistics>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/achievements/statistics?namespace={@namespace}&locale={locale}");
    }
}
