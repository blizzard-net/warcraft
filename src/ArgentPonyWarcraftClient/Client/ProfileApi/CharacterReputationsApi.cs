namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterReputationsSummary>> GetCharacterReputationsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterReputationsSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterReputationsSummary>> GetCharacterReputationsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterReputationsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/reputations?namespace={@namespace}&locale={locale}");
    }
}
