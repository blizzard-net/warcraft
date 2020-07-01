using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace)
        {
            return await GetMythicKeystoneDungeonsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneDungeonsIndex>> GetMythicKeystoneDungeonsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneDungeonsIndex>(region, $"{host}/data/wow/mythic-keystone/dungeon/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace)
        {
            return await GetMythicKeystoneDungeonAsync(dungeonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneDungeon>(region, $"{host}/data/wow/mythic-keystone/dungeon/{dungeonId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace)
        {
            return await GetMythicKeystoneIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneIndex>(region, $"{host}/data/wow/mythic-keystone/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace)
        {
            return await GetMythicKeystonePeriodsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystonePeriodsIndex>> GetMythicKeystonePeriodsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystonePeriodsIndex>(region, $"{host}/data/wow/mythic-keystone/period/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace)
        {
            return await GetMythicKeystonePeriodAsync(periodId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystonePeriod>(region, $"{host}/data/wow/mythic-keystone/period/{periodId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace)
        {
            return await GetMythicKeystoneSeasonsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneSeasonsIndex>> GetMythicKeystoneSeasonsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneSeasonsIndex>(region, $"{host}/data/wow/mythic-keystone/season/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace)
        {
            return await GetMythicKeystoneSeasonAsync(seasonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneSeason>(region, $"{host}/data/wow/mythic-keystone/season/{seasonId}?namespace={@namespace}&locale={locale}");
        }
    }
}
