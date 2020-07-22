using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace)
        {
            return await GetAccountProfileSummaryAsync(accessToken, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AccountProfileSummary>($"{host}/profile/user/wow?namespace={@namespace}&locale={locale}", accessToken);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace)
        {
            return await GetProtectedCharacterProfileSummaryAsync(realmId, characterId, accessToken, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ProtectedCharacterProfileSummary>($"{host}/profile/user/wow/protected-character/{realmId}-{characterId}?namespace={@namespace}&locale={locale}", accessToken);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace)
        {
            return await GetAccountCollectionsIndexAsync(accessToken, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AccountCollectionsIndex>($"{host}/profile/user/wow/collections?namespace={@namespace}&locale={locale}", accessToken);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace)
        {
            return await GetAccountMountsCollectionSummaryAsync(accessToken, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AccountMountsCollectionSummary>($"{host}/profile/user/wow/collections/mounts?namespace={@namespace}&locale={locale}", accessToken);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace)
        {
            return await GetAccountPetsCollectionSummaryAsync(accessToken, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AccountPetsCollectionSummary>($"{host}/profile/user/wow/collections/pets?namespace={@namespace}&locale={locale}", accessToken);
        }
    }
}
