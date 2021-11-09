namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace)
    {
        return await GetRegionsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<RegionsIndex>($"{host}/data/wow/region/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace)
    {
        return await GetRegionAsync(regionId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<RegionData>($"{host}/data/wow/region/{regionId}?namespace={@namespace}&locale={locale}");
    }
}
