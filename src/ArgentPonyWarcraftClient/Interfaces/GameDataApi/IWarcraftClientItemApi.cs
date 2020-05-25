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
    }
}
