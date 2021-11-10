namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterProfileSummary>> GetCharacterProfileSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterProfileSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterProfileSummary>> GetCharacterProfileSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterProfileSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterStatus>> GetCharacterStatusAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterStatusAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterStatus>> GetCharacterStatusAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterStatus>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/status?namespace={@namespace}&locale={locale}");
    }
}
