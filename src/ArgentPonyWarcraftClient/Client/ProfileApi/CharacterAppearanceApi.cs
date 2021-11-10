namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterAppearanceSummary>> GetCharacterAppearanceSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterAppearanceSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterAppearanceSummary>> GetCharacterAppearanceSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterAppearanceSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/appearance?namespace={@namespace}&locale={locale}");
    }
}
