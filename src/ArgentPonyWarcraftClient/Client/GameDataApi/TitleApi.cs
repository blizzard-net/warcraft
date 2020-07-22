using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace)
        {
            return await GetTitlesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<TitlesIndex>> GetTitlesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<TitlesIndex>(region, $"{host}/data/wow/title/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace)
        {
            return await GetTitleAsync(titleId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Title>> GetTitleAsync(int titleId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Title>(region, $"{host}/data/wow/title/{titleId}?namespace={@namespace}&locale={locale}");
        }
    }
}
