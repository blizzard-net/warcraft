namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace)
    {
        return await GetItemClassesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemClassesIndex>($"{host}/data/wow/item-class/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace)
    {
        return await GetItemClassAsync(itemClassId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemClass>($"{host}/data/wow/item-class/{itemClassId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSetsIndex>> GetItemSetsIndexAsync(string @namespace)
    {
        return await GetItemSetsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSetsIndex>> GetItemSetsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemSetsIndex>($"{host}/data/wow/item-set/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, string @namespace)
    {
        return await GetItemSetAsync(itemSetId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemSet>($"{host}/data/wow/item-set/{itemSetId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSubclass>> GetItemSubclassAsync(int itemClassId, int itemSubclassId, string @namespace)
    {
        return await GetItemSubclassAsync(itemClassId, itemSubclassId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemSubclass>> GetItemSubclassAsync(int itemClassId, int itemSubclassId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemSubclass>($"{host}/data/wow/item-class/{itemClassId}/item-subclass/{itemSubclassId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace)
    {
        return await GetItemAsync(itemId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Item>($"{host}/data/wow/item/{itemId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace)
    {
        return await GetItemMediaAsync(itemId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ItemMedia>($"{host}/data/wow/media/item/{itemId}?namespace={@namespace}&locale={locale}");
    }
}
