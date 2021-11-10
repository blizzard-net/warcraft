namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<RealmsIndex>> GetRealmsIndexAsync(string @namespace)
    {
        return await GetRealmsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<RealmsIndex>> GetRealmsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<RealmsIndex>($"{host}/data/wow/realm/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Realm>> GetRealmAsync(string realmSlug, string @namespace)
    {
        return await GetRealmAsync(realmSlug, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Realm>> GetRealmAsync(string realmSlug, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Realm>($"{host}/data/wow/realm/{realmSlug}?namespace={@namespace}&locale={locale}");
    }
}
