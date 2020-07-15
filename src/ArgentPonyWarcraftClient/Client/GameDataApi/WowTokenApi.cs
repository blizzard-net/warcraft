using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace)
        {
            return await GetWowTokenIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<WowTokenIndex>> GetWowTokenIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<WowTokenIndex>(region, $"{host}/data/wow/token/index?namespace={@namespace}&locale={locale}");
        }
    }
}
