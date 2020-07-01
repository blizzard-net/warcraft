using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace)
        {
            return await GetMythicRaidLeaderboardAsync(raid, faction, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicRaidLeaderboard>(region, $"{host}/data/wow/leaderboard/hall-of-fame/{raid}/{faction}?namespace={@namespace}&locale={locale}");
        }
    }
}
