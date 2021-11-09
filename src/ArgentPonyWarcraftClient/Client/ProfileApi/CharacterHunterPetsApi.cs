namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterHunterPetsSummary>> GetCharacterHunterPetsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterHunterPetsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterHunterPetsSummary>> GetCharacterHunterPetsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterHunterPetsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/hunter-pets?namespace={@namespace}&locale={locale}");
    }
}
