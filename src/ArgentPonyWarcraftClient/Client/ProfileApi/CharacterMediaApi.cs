namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterMediaSummary>> GetCharacterMediaSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterMediaSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterMediaSummary>> GetCharacterMediaSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterMediaSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/character-media?namespace={@namespace}&locale={locale}");
    }
}
