using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffixesIndex>> GetMythicKeystoneAffixesIndexAsync(string @namespace)
        {
            return await GetMythicKeystoneAffixesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffixesIndex>> GetMythicKeystoneAffixesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneAffixesIndex>(region, $"{host}/data/wow/keystone-affix/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId, string @namespace)
        {
            return await GetMythicKeystoneAffixAsync(keystoneAffixId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneAffix>(region, $"{host}/data/wow/keystone-affix/{keystoneAffixId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffixMedia>> GetMythicKeystoneAffixMediaAsync(int keystoneAffixId, string @namespace)
        {
            return await GetMythicKeystoneAffixMediaAsync(keystoneAffixId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneAffixMedia>> GetMythicKeystoneAffixMediaAsync(int keystoneAffixId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneAffixMedia>(region, $"{host}/data/wow/media/keystone-affix/{keystoneAffixId}?namespace={@namespace}&locale={locale}");
        }
    }
}
