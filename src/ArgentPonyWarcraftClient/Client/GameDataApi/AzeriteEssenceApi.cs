namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssencesIndex>> GetAzeriteEssencesIndexAsync(string @namespace)
    {
        return await GetAzeriteEssencesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssencesIndex>> GetAzeriteEssencesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AzeriteEssencesIndex>($"{host}/data/wow/azerite-essence/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssence>> GetAzeriteEssenceAsync(int azeriteEssenceId, string @namespace)
    {
        return await GetAzeriteEssenceAsync(azeriteEssenceId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssence>> GetAzeriteEssenceAsync(int azeriteEssenceId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AzeriteEssence>($"{host}/data/wow/azerite-essence/{azeriteEssenceId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssenceMedia>> GetAzeriteEssenceMediaAsync(int azeriteEssenceId, string @namespace)
    {
        return await GetAzeriteEssenceMediaAsync(azeriteEssenceId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AzeriteEssenceMedia>> GetAzeriteEssenceMediaAsync(int azeriteEssenceId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AzeriteEssenceMedia>($"{host}/data/wow/media/azerite-essence/{azeriteEssenceId}?namespace={@namespace}&locale={locale}");
    }
}
