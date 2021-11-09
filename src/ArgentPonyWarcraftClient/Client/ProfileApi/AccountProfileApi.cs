namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace)
    {
        return await GetAccountProfileSummaryAsync(accessToken, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountProfileSummary>> GetAccountProfileSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AccountProfileSummary>($"{host}/profile/user/wow?namespace={@namespace}&locale={locale}", accessToken);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace)
    {
        return await GetProtectedCharacterProfileSummaryAsync(realmId, characterId, accessToken, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ProtectedCharacterProfileSummary>> GetProtectedCharacterProfileSummaryAsync(int realmId, int characterId, string accessToken, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ProtectedCharacterProfileSummary>($"{host}/profile/user/wow/protected-character/{realmId}-{characterId}?namespace={@namespace}&locale={locale}", accessToken);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace)
    {
        return await GetAccountCollectionsIndexAsync(accessToken, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountCollectionsIndex>> GetAccountCollectionsIndexAsync(string accessToken, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AccountCollectionsIndex>($"{host}/profile/user/wow/collections?namespace={@namespace}&locale={locale}", accessToken);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace)
    {
        return await GetAccountMountsCollectionSummaryAsync(accessToken, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountMountsCollectionSummary>> GetAccountMountsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AccountMountsCollectionSummary>($"{host}/profile/user/wow/collections/mounts?namespace={@namespace}&locale={locale}", accessToken);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace)
    {
        return await GetAccountPetsCollectionSummaryAsync(accessToken, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AccountPetsCollectionSummary>> GetAccountPetsCollectionSummaryAsync(string accessToken, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AccountPetsCollectionSummary>($"{host}/profile/user/wow/collections/pets?namespace={@namespace}&locale={locale}", accessToken);
    }
}
