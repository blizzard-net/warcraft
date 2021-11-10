namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterStatisticsSummary>> GetCharacterStatisticsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterStatisticsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterStatisticsSummary>> GetCharacterStatisticsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterStatisticsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/statistics?namespace={@namespace}&locale={locale}");
    }
}
