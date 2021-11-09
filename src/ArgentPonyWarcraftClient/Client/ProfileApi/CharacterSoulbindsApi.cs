using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterSoulbinds>> GetCharacterSoulbindsAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterSoulbindsAsync(realmSlug, characterName, @namespace, _region, _locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterSoulbinds>> GetCharacterSoulbindsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterSoulbinds>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/soulbinds?namespace={@namespace}&locale={locale}");
    }
}
