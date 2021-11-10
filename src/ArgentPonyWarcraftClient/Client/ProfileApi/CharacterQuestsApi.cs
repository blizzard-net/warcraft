namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CharacterQuests>> GetCharacterQuestsAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterQuestsAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterQuests>> GetCharacterQuestsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterQuests>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/quests?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterCompletedQuests>> GetCharacterCompletedQuestsAsync(string realmSlug, string characterName, string @namespace)
    {
        return await GetCharacterCompletedQuestsAsync(realmSlug, characterName, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CharacterCompletedQuests>> GetCharacterCompletedQuestsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CharacterCompletedQuests>($"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/quests/completed?namespace={@namespace}&locale={locale}");
    }
}
