namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace)
    {
        return await GetAuctionsAsync(connectedRealmId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AuctionsIndex>($"{host}/data/wow/connected-realm/{connectedRealmId}/auctions?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CommoditiesIndex>> GetCommoditiesAsync(string @namespace)
    {
        return await GetCommoditiesAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CommoditiesIndex>> GetCommoditiesAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CommoditiesIndex>($"{host}/data/wow/auctions/commodities?namespace={@namespace}&locale={locale}");
    }
}
