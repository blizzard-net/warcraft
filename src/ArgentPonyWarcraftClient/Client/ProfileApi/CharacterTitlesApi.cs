namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterTitlesSummary>> GetCharacterTitlesSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterTitlesSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterTitlesSummary>> GetCharacterTitlesSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterTitlesSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/titles?namespace={@namespace}&locale={locale}");
    }
}
