namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Modified Crafting API.
/// </summary>
public interface IModifiedCraftingApi
{
    /// <summary>
    ///     Gets the parent index for Modified Crafting.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The parent index for Modified Crafting.
    /// </returns>
    Task<RequestResult<ModifiedCraftingIndex>> GetModifiedCraftingIndexAsync(string @namespace);

    /// <summary>
    ///     Gets the parent index for Modified Crafting.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The parent index for Modified Crafting.
    /// </returns>
    Task<RequestResult<ModifiedCraftingIndex>> GetModifiedCraftingIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets the index of Modified Crafting categories.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of Modified Crafting categories.
    /// </returns>
    Task<RequestResult<ModifiedCraftingCategoryIndex>> GetModifiedCraftingCategoryIndexAsync(string @namespace);

    /// <summary>
    ///     Gets the index of Modified Crafting categories.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The index of Modified Crafting categories.
    /// </returns>
    Task<RequestResult<ModifiedCraftingCategoryIndex>> GetModifiedCraftingCategoryIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified Modified Crafting category.
    /// </summary>
    /// <param name="categoryId">The ID of the Modified Crafting category.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified Modified Crafting category.
    /// </returns>
    Task<RequestResult<ModifiedCraftingCategory>> GetModifiedCraftingCategoryAsync(int categoryId, string @namespace);

    /// <summary>
    ///     Get the specified Modified Crafting category.
    /// </summary>
    /// <param name="categoryId">The ID of the Modified Crafting category.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified Modified Crafting category.
    /// </returns>
    Task<RequestResult<ModifiedCraftingCategory>> GetModifiedCraftingCategoryAsync(int categoryId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets the index of Modified Crafting reagent slot types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The index of Modified Crafting reagent slot types.
    /// </returns>
    Task<RequestResult<ModifiedCraftingReagentSlotTypeIndex>> GetModifiedCraftingReagentSlotTypeIndexAsync(string @namespace);

    /// <summary>
    ///     Gets the index of Modified Crafting reagent slot types.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The iindex of Modified Crafting reagent slot types.
    /// </returns>
    Task<RequestResult<ModifiedCraftingReagentSlotTypeIndex>> GetModifiedCraftingReagentSlotTypeIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified Modified Crafting reagent slot type.
    /// </summary>
    /// <param name="slotTypeId">The ID of the Modified Crafting reagent slot type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified Modified Crafting reagent slot type.
    /// </returns>
    Task<RequestResult<ModifiedCraftingReagentSlotType>> GetModifiedCraftingReagentSlotTypeAsync(int slotTypeId, string @namespace);

    /// <summary>
    ///     Get the specified Modified Crafting reagent slot type.
    /// </summary>
    /// <param name="slotTypeId">The ID of the Modified Crafting reagent slot type.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified Modified Crafting reagent slot type.
    /// </returns>
    Task<RequestResult<ModifiedCraftingReagentSlotType>> GetModifiedCraftingReagentSlotTypeAsync(int slotTypeId, string @namespace, Region region, Locale locale);
}
