namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace)
    {
        return await GetMythicRaidLeaderboardAsync(raid, faction, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<MythicRaidLeaderboard>($"{host}/data/wow/leaderboard/hall-of-fame/{raid}/{faction}?namespace={@namespace}&locale={locale}");
    }
}
