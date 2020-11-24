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
        /// The <see cref="CovenantsIndex"/>.
        /// </returns>
        Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace);

        /// <summary>
        /// Gets an index of covenants.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language the result will be in.</param>
        /// <returns>
        /// The <see cref="CovenantsIndex"/>.
        /// </returns>
        Task<RequestResult<CovenantsIndex>> GetCovenantsIndexAsync(string @namespace, Region region, Locale locale);

        /// <summary>
        /// Gets a covenant by Id.
        /// </summary>
        /// <param name="covenantId">The Id of the covenant.</param>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        /// The <see cref="Covenant"/>.
        /// </returns>
        Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace);

        /// <summary>
        /// Gets a covenant by Id.
        /// </summary>
        /// <param name="covenantId">The Id of the covenant.</param>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language the result will be in.</param>
        /// <returns>
        /// The <see cref="Covenant"/>.
        /// </returns>
        Task<RequestResult<Covenant>> GetCovenantAsync(int covenantId, string @namespace, Region region, Locale locale);

        /// <summary>
        /// Gets media for a covenant by the covenant Id.
        /// </summary>
        /// <param name="covenantId">The Id of the covenant.</param>
        /// <param name="namespace"></param>
        /// <returns>
        /// Media for a covenant.
        /// </returns>
        Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace);

        /// <summary>
        /// Gets media for a covenant by the covenant Id.
        /// </summary>
        /// <param name="covenantId">The Id of the covenant.</param>
        /// <param name="namespace"></param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language the result will be in.</param>
        /// <returns>
        /// Media for a covenant.
        /// </returns>
        Task<RequestResult<CovenantMedia>> GetCovenantMediaAsync(int covenantId, string @namespace, Region region, Locale locale);
    }
}
