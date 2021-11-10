namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Item API.
/// </summary>
public interface IItemApi
{
    /// <summary>
    ///     Gets an index of item classes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The item classes index.
    /// </returns>
    Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of item classes.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The item classes index.
    /// </returns>
    Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified item class.
    /// </summary>
    /// <param name="itemClassId">The ID of the item class.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified item class.
    /// </returns>
    Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace);

    /// <summary>
    ///     Get the specified item class.
    /// </summary>
    /// <param name="itemClassId">The ID of the item class.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified item class.
    /// </returns>
    Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of item sets.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The item sets index.
    /// </returns>
    Task<RequestResult<ItemSetsIndex>> GetItemSetsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of item sets.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The item sets index.
    /// </returns>
    Task<RequestResult<ItemSetsIndex>> GetItemSetsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified item set.
    /// </summary>
    /// <param name="itemSetId">The ID of the item set.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified item set.
    /// </returns>
    Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, string @namespace);

    /// <summary>
    ///     Get the specified item set.
    /// </summary>
    /// <param name="itemSetId">The ID of the item set.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified item set.
    /// </returns>
    Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified item subclass.
    /// </summary>
    /// <param name="itemClassId">The ID of the item class.</param>
    /// <param name="itemSubclassId">The ID of the item subclass.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified item subclass.
    /// </returns>
    Task<RequestResult<ItemSubclass>> GetItemSubclassAsync(int itemClassId, int itemSubclassId, string @namespace);

    /// <summary>
    ///     Get the specified item subclass.
    /// </summary>
    /// <param name="itemClassId">The ID of the item class.</param>
    /// <param name="itemSubclassId">The ID of the item subclass.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified item subclass.
    /// </returns>
    Task<RequestResult<ItemSubclass>> GetItemSubclassAsync(int itemClassId, int itemSubclassId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified item.
    /// </summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified item.
    /// </returns>
    Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace);

    /// <summary>
    ///     Get the specified item.
    /// </summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified item.
    /// </returns>
    Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for an item by ID.
    /// </summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for an item by ID.
    /// </returns>
    Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace);

    /// <summary>
    ///     Get media for an item by ID.
    /// </summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for an item by ID.
    /// </returns>
    Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace, Region region, Locale locale);
}
