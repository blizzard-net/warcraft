using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace) =>
            GetCovenantsIndexAsync(@namespace, _region, _locale);

        /// <inheritdoc />
        public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return GetAsync<CovenantsIndex>($"{host}/data/wow/covenant/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace) =>
            GetCovenantAsync(covenantId, @namespace, _region, _locale);

        /// <inheritdoc />
        public Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace, Region region, Locale locale) => throw new System.NotImplementedException();
    }
}
