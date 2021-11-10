namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterSpecializationsSummary>> GetCharacterSpecializationsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterSpecializationsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterSpecializationsSummary>> GetCharacterSpecializationsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterSpecializationsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/specializations?namespace={@namespace}&locale={locale}");
    }
}
