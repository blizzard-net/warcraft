using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterHunterPetsSummary>> GetCharacterHunterPetsSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterHunterPetsSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterHunterPetsSummary>> GetCharacterHunterPetsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterHunterPetsSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/hunter-pets?namespace={@namespace}&locale={locale}");
    }
}
