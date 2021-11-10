namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterEquipmentSummary>> GetCharacterEquipmentSummaryAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterEquipmentSummaryAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterEquipmentSummary>> GetCharacterEquipmentSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterEquipmentSummary>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/equipment?namespace={@namespace}&locale={locale}");
    }
}
