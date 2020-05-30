using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Pet API.
    /// </summary>
    public interface IWarcraftClientPetApi
    {
        /// <summary>
        ///     Gets an index of pets.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        ///     The pet index.
        /// </returns>
        Task<RequestResult<PetsIndex>> GetPetsIndexAsync(string @namespace);

        /// <summary>
        ///     Gets an index of pets.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The pet index.
        /// </returns>
        Task<RequestResult<PetsIndex>> GetPetsIndexAsync(string @namespace, Region region, Locale locale);

        /// <summary>
        ///     Get the specified pet.
        /// </summary>
        /// <param name="petId">The pet ID.</param>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        ///     The specified pet.
        /// </returns>
        Task<RequestResult<Pet>> GetPetAsync(int petId, string @namespace);

        /// <summary>
        ///     Get the specified pet.
        /// </summary>
        /// <param name="petId">The pet ID.</param>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified pet.
        /// </returns>
        Task<RequestResult<Pet>> GetPetAsync(int petId, string @namespace, Region region, Locale locale);
    }
}
