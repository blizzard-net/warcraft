namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace)
    {
        return await GetTalentsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<TalentsIndex>($"{host}/data/wow/talent/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace)
    {
        return await GetTalentAsync(talentId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Talent>($"{host}/data/wow/talent/{talentId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace)
    {
        return await GetPvpTalentsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTalentsIndex>($"{host}/data/wow/pvp-talent/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace)
    {
        return await GetPvpTalentAsync(pvpTalentId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpTalent>($"{host}/data/wow/pvp-talent/{pvpTalentId}?namespace={@namespace}&locale={locale}");
    }
}
