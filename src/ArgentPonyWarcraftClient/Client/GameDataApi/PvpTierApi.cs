namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PvpTiersIndex>> GetPvpTiersIndexAsync(string @namespace)
    {
        return await GetPvpTiersIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTiersIndex>> GetPvpTiersIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTiersIndex>($"{host}/data/wow/pvp-tier/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTier>> GetPvpTierAsync(int pvpTierId, string @namespace)
    {
        return await GetPvpTierAsync(pvpTierId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTier>> GetPvpTierAsync(int pvpTierId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTier>($"{host}/data/wow/pvp-tier/{pvpTierId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTierMedia>> GetPvpTierMediaAsync(int pvpTierId, string @namespace)
    {
        return await GetPvpTierMediaAsync(pvpTierId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTierMedia>> GetPvpTierMediaAsync(int pvpTierId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTierMedia>($"{host}/data/wow/media/pvp-tier/{pvpTierId}?namespace={@namespace}&locale={locale}");
    }
}
