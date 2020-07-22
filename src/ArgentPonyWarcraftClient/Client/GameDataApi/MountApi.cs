using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<MountsIndex>> GetMountsIndexAsync(string @namespace)
        {
            return await GetMountsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MountsIndex>> GetMountsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<MountsIndex>(region, $"{host}/data/wow/mount/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Mount>> GetMountAsync(int mountId, string @namespace)
        {
            return await GetMountAsync(mountId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Mount>> GetMountAsync(int mountId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Mount>(region, $"{host}/data/wow/mount/{mountId}?namespace={@namespace}&locale={locale}");
        }
    }
}
