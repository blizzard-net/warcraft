namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace)
    {
        return await GetReputationFactionsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ReputationFactionsIndex>($"{host}/data/wow/reputation-faction/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace)
    {
        return await GetReputationFactionAsync(reputationFactionId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ReputationFaction>($"{host}/data/wow/reputation-faction/{reputationFactionId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace)
    {
        return await GetReputationTiersIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ReputationTiersIndex>($"{host}/data/wow/reputation-tiers/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace)
    {
        return await GetReputationTiersAsync(reputationTiersId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ReputationTiers>($"{host}/data/wow/reputation-tiers/{reputationTiersId}?namespace={@namespace}&locale={locale}");
    }
}
