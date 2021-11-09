namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace)
    {
        return await GetTitlesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<TitlesIndex>($"{host}/data/wow/title/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace)
    {
        return await GetTitleAsync(titleId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Title>($"{host}/data/wow/title/{titleId}?namespace={@namespace}&locale={locale}");
    }
}
