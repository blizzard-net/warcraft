namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace)
    {
        return await GetMythicKeystoneDungeonsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneDungeonsIndex>($"{host}/data/wow/mythic-keystone/dungeon/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace)
    {
        return await GetMythicKeystoneDungeonAsync(dungeonId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneDungeon>($"{host}/data/wow/mythic-keystone/dungeon/{dungeonId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace)
    {
        return await GetMythicKeystoneIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneIndex>($"{host}/data/wow/mythic-keystone/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace)
    {
        return await GetMythicKeystonePeriodsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystonePeriodsIndex>($"{host}/data/wow/mythic-keystone/period/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace)
    {
        return await GetMythicKeystonePeriodAsync(periodId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystonePeriod>($"{host}/data/wow/mythic-keystone/period/{periodId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace)
    {
        return await GetMythicKeystoneSeasonsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneSeasonsIndex>($"{host}/data/wow/mythic-keystone/season/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace)
    {
        return await GetMythicKeystoneSeasonAsync(seasonId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneSeason>($"{host}/data/wow/mythic-keystone/season/{seasonId}?namespace={@namespace}&locale={locale}");
    }
}
