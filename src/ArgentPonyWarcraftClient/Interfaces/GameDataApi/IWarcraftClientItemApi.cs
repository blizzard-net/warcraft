using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Item API.
    /// </summary>
    public interface IWarcraftClientItemApi
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
}
