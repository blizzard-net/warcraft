using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace)
        {
            return await GetRegionsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<RegionsIndex>> GetRegionsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<RegionsIndex>(region, $"{host}/data/wow/region/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace)
        {
            return await GetRegionAsync(regionId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<RegionData>> GetRegionAsync(int regionId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<RegionData>(region, $"{host}/data/wow/region/{regionId}?namespace={@namespace}&locale={locale}");
        }
    }
}
