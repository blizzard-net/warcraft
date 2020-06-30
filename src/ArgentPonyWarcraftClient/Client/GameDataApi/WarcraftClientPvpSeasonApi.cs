using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace)
        {
            return await GetPvpSeasonsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpSeasonsIndex>(region, $"{host}/data/wow/pvp-season/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace)
        {
            return await GetPvpSeasonAsync(pvpSeasonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpSeason>(region, $"{host}/data/wow/pvp-season/{pvpSeasonId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpSeasonId, string @namespace)
        {
            return await GetPvpLeaderboardsIndexAsync(pvpSeasonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpSeasonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpLeaderboardsIndex>(region, $"{host}/data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpSeasonId, string pvpBracket, string @namespace)
        {
            return await GetPvpLeaderboardAsync(pvpSeasonId, pvpBracket, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpSeasonId, string pvpBracket, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpLeaderboard>(region, $"{host}/data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/{pvpBracket}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpSeasonId, string @namespace)
        {
            return await GetPvpRewardsIndexAsync(pvpSeasonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpSeasonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpRewardsIndex>(region, $"{host}/data/wow/pvp-season/{pvpSeasonId}/pvp-reward/index?namespace={@namespace}&locale={locale}");
        }
    }
}
