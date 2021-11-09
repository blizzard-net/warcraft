namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreesIndexAsync(string @namespace) =>
        GetTechTalentTreesIndexAsync(@namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<TechTalentTreesIndex>> GetTechTalentTreesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<TechTalentTreesIndex>($"{host}/data/wow/tech-talent-tree/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace) => GetTechTalentTreeAsync(techTalentTreeId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<TechTalentTree>> GetTechTalentTreeAsync(int techTalentTreeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<TechTalentTree>($"{host}/data/wow/tech-talent-tree/{techTalentTreeId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace) =>
        GetTechTalentsIndexAsync(@namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<TechTalentsIndex>> GetTechTalentsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<TechTalentsIndex>($"{host}/data/wow/tech-talent/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace) =>
        GetTechTalentAsync(techTalentId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<TechTalent>> GetTechTalentAsync(int techTalentId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<TechTalent>($"{host}/data/wow/tech-talent/{techTalentId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public Task<RequestResult<TechTalentMedia>> GetTechTalentMediaAsync(int techTalentId, string @namespace) =>
        GetTechTalentMediaAsync(techTalentId, @namespace, Region, Locale);

    /// <inheritdoc />
    public Task<RequestResult<TechTalentMedia>> GetTechTalentMediaAsync(int techTalentId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return GetAsync<TechTalentMedia>($"{host}/data/wow/media/tech-talent/{techTalentId}?namespace={@namespace}&locale={locale}");
    }
}
