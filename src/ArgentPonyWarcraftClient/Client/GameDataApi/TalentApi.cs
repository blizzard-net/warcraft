namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<TalentTreeIndex>> GetTalentTreeIndexAsync(string @namespace)
    {
        return await GetTalentTreeIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />>
    public async Task<RequestResult<TalentTreeIndex>> GetTalentTreeIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<TalentTreeIndex>($"{host}/data/wow/talent-tree/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<TalentTree>> GetTalentTreeAsync(int talentTreeId, int specId, string @namespace)
    {
        return await GetTalentTreeAsync(talentTreeId, specId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<TalentTree>> GetTalentTreeAsync(int talentTreeId, int specId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<TalentTree>($"{host}/data/wow/talent-tree/{talentTreeId}/playable-specialization/{specId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<TalentTreeNodes>> GetTalentTreeNodesAsync(int talentTreeId, string @namespace)
    {
        return await GetTalentTreeNodesAsync(talentTreeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<TalentTreeNodes>> GetTalentTreeNodesAsync(int talentTreeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<TalentTreeNodes>($"{host}/data/wow/talent-tree/{talentTreeId}?namespace={@namespace}&locale={locale}");
    }

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
