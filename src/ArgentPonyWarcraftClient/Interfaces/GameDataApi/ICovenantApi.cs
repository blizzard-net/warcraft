using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A client for retrieving covenant data from the World of Warcraft Game Data APIs.
    /// </summary>
    public interface ICovenantApi
    {
        /// <summary>
        /// Gets an index of covenants.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        /// The covenants index.
        /// </returns>
        Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace);

        /// <summary>
        /// Gets an index of covenants.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language the result will be in.</param>
        /// <returns>
        /// The covenants index.
        /// </returns>
        Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale);
    }
}
