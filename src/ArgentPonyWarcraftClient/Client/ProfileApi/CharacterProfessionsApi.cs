namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterProfessionsSummary>> GetCharacterProfessionsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterProfessionsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterProfessionsSummary>> GetCharacterProfessionsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterProfessionsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/professions?namespace={@namespace}&locale={locale}");
    }
}
