namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace)
    {
        return await GetPlayableSpecializationsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableSpecializationsIndex>($"{host}/data/wow/playable-specialization/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace)
    {
        return await GetPlayableSpecializationAsync(specId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableSpecialization>($"{host}/data/wow/playable-specialization/{specId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace)
    {
        return await GetPlayableSpecializationMediaAsync(specId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableSpecializationMedia>($"{host}/data/wow/media/playable-specialization/{specId}?namespace={@namespace}&locale={locale}");
    }
}
