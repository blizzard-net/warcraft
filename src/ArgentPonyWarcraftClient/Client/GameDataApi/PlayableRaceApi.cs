namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace)
    {
        return await GetPlayableRacesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableRacesIndex>($"{host}/data/wow/playable-race/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace)
    {
        return await GetPlayableRaceAsync(playableRaceId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PlayableRace>($"{host}/data/wow/playable-race/{playableRaceId}?namespace={@namespace}&locale={locale}");
    }
}
