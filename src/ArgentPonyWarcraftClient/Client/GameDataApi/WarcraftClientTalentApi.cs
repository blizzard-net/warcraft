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
            return await Get<TalentsIndex>(region, $"{host}/data/wow/talent/index?namespace={@namespace}&locale={locale}");
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
            return await Get<Talent>(region, $"{host}/data/wow/talent/{talentId}?namespace={@namespace}&locale={locale}");
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
            return await Get<PvpTalentsIndex>(region, $"{host}/data/wow/pvp-talent/index?namespace={@namespace}&locale={locale}");
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
            return await Get<PvpTalent>(region, $"{host}/data/wow/pvp-talent/{pvpTalentId}?namespace={@namespace}&locale={locale}");
        }
    }
}
