namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace)
    {
        return await GetCharacterPvpBracketStatisticsAsync(realmSlug, characterName, pvpBracket, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterPvpBracketStatistics>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/pvp-bracket/{pvpBracket}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterPvpSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterPvpSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/pvp-summary?namespace={@namespace}&locale={locale}");
    }
}
