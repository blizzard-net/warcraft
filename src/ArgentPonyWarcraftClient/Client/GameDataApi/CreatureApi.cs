namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace)
    {
        return await GetCreatureFamiliesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureFamiliesIndex>($"{host}/data/wow/creature-family/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace)
    {
        return await GetCreatureFamilyAsync(creatureFamilyId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureFamily>($"{host}/data/wow/creature-family/{creatureFamilyId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace)
    {
        return await GetCreatureTypesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureTypesIndex>($"{host}/data/wow/creature-type/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace)
    {
        return await GetCreatureTypeAsync(creatureTypeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureType>($"{host}/data/wow/creature-type/{creatureTypeId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace)
    {
        return await GetCreatureAsync(creatureId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Creature>($"{host}/data/wow/creature/{creatureId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace)
    {
        return await GetCreatureDisplayMediaAsync(creatureDisplayId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureDisplayMedia>($"{host}/data/wow/media/creature-display/{creatureDisplayId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace)
    {
        return await GetCreatureFamilyMediaAsync(creatureFamilyId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<CreatureFamilyMedia>($"{host}/data/wow/media/creature-family/{creatureFamilyId}?namespace={@namespace}&locale={locale}");
    }
}
