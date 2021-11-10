namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PowerTypesIndex>> GetPowerTypesIndexAsync(string @namespace)
    {
        return await GetPowerTypesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PowerTypesIndex>> GetPowerTypesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PowerTypesIndex>($"{host}/data/wow/power-type/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId, string @namespace)
    {
        return await GetPowerTypeAsync(powerTypeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PowerType>($"{host}/data/wow/power-type/{powerTypeId}?namespace={@namespace}&locale={locale}");
    }
}
