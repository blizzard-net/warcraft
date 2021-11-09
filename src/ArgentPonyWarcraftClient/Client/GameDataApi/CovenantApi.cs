namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace) =>
        GetCovenantsIndexAsync(@namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<CovenantsIndex>($"{host}/data/wow/covenant/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace) =>
        GetCovenantAsync(covenantId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<Covenant>($"{host}/data/wow/covenant/{covenantId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace) =>
        GetCovenantMediaAsync(covenantId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<CovenantMedia>($"{host}/data/wow/media/covenant/{covenantId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<SoulbindsIndex>> GetSoulbindsIndexAsync(string @namespace) => GetSoulbindsIndexAsync(@namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<SoulbindsIndex>> GetSoulbindsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<SoulbindsIndex>($"{host}/data/wow/covenant/soulbind/index?namespace=static-us&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<Soulbind>> GetSoulbindAsync(int soulbindId, string @namespace) => GetSoulbindAsync(soulbindId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<Soulbind>> GetSoulbindAsync(int soulbindId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<Soulbind>($"{host}/data/wow/covenant/soulbind/{soulbindId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<ConduitsIndex>> GetConduitsIndexAsync(string @namespace) =>
        GetConduitsIndexAsync(@namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<ConduitsIndex>> GetConduitsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<ConduitsIndex>($"{host}/data/wow/covenant/conduit/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<Conduit>> GetConduitAsync(int conduitId, string @namespace) => GetConduitAsync(conduitId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<Conduit>> GetConduitAsync(int conduitId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<Conduit>($"{host}/data/wow/covenant/conduit/{conduitId}?namespace={@namespace}&locale={locale}");
    }
}
