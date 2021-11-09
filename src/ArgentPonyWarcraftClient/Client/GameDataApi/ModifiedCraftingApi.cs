namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingIndex>> GetModifiedCraftingIndexAsync(string @namespace)
    {
        return await GetModifiedCraftingIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingIndex>> GetModifiedCraftingIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ModifiedCraftingIndex>($"{host}/data/wow/modified-crafting/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingCategoryIndex>> GetModifiedCraftingCategoryIndexAsync(string @namespace)
    {
        return await GetModifiedCraftingCategoryIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingCategoryIndex>> GetModifiedCraftingCategoryIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ModifiedCraftingCategoryIndex>($"{host}/data/wow/modified-crafting/category/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingCategory>> GetModifiedCraftingCategoryAsync(int categoryId, string @namespace)
    {
        return await GetModifiedCraftingCategoryAsync(categoryId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingCategory>> GetModifiedCraftingCategoryAsync(int categoryId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ModifiedCraftingCategory>($"{host}/data/wow/modified-crafting/category/{categoryId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingReagentSlotTypeIndex>> GetModifiedCraftingReagentSlotTypeIndexAsync(string @namespace)
    {
        return await GetModifiedCraftingReagentSlotTypeIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingReagentSlotTypeIndex>> GetModifiedCraftingReagentSlotTypeIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ModifiedCraftingReagentSlotTypeIndex>($"{host}/data/wow/modified-crafting/reagent-slot-type/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingReagentSlotType>> GetModifiedCraftingReagentSlotTypeAsync(int slotTypeId, string @namespace)
    {
        return await GetModifiedCraftingReagentSlotTypeAsync(slotTypeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ModifiedCraftingReagentSlotType>> GetModifiedCraftingReagentSlotTypeAsync(int slotTypeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ModifiedCraftingReagentSlotType>($"{host}/data/wow/modified-crafting/reagent-slot-type/{slotTypeId}?namespace={@namespace}&locale={locale}");
    }
}
