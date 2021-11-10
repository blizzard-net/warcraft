namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace)
    {
        return await GetPlayableClassesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableClassesIndex>($"{host}/data/wow/playable-class/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace)
    {
        return await GetPlayableClassAsync(classId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableClass>($"{host}/data/wow/playable-class/{classId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace)
    {
        return await GetPlayableClassMediaAsync(classId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableClassMedia>($"{host}/data/wow/media/playable-class/{classId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace)
    {
        return await GetPvpTalentSlotsAsync(classId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTalentSlots>($"{host}/data/wow/playable-class/{classId}/pvp-talent-slots?namespace={@namespace}&locale={locale}");
    }
}
