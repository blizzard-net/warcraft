namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace)
    {
        return await GetWowTokenIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<WowTokenIndex>($"{host}/data/wow/token/index?namespace={@namespace}&locale={locale}");
    }
}
