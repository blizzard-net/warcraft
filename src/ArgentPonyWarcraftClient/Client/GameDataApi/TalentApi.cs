using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace)
        {
            return await GetTalentsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<TalentsIndex>> GetTalentsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<TalentsIndex>(region, $"{host}/data/wow/talent/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace)
        {
            return await GetTalentAsync(talentId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Talent>> GetTalentAsync(int talentId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Talent>(region, $"{host}/data/wow/talent/{talentId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace)
        {
            return await GetPvpTalentsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalentsIndex>> GetPvpTalentsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PvpTalentsIndex>(region, $"{host}/data/wow/pvp-talent/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace)
        {
            return await GetPvpTalentAsync(pvpTalentId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalent>> GetPvpTalentAsync(int pvpTalentId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PvpTalent>(region, $"{host}/data/wow/pvp-talent/{pvpTalentId}?namespace={@namespace}&locale={locale}");
        }
    }
}
