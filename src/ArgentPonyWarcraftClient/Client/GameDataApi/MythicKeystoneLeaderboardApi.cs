namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace)
    {
        return await GetMythicKeystoneLeaderboardsIndexAsync(connectedRealmId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneLeaderboardsIndex>($"{host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace)
    {
        return await GetMythicKeystoneLeaderboard(connectedRealmId, dungeonId, period, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicKeystoneLeaderboard>($"{host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/{dungeonId}/period/{period}?namespace={@namespace}&locale={locale}");
    }
}
