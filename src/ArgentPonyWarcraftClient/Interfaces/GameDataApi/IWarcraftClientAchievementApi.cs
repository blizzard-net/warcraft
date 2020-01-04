using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Game Data APIs.
    /// </summary>
    public interface IWarcraftClientAchievementApi
    {
        /// <summary>
        ///     Get the achievement categories index.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        ///     The achievement categories index.
        /// </returns>
        Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace);

        /// <summary>
        ///     Get the achievement categories index.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The achievement categories index.
        /// </returns>
        Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace, Region region, Locale locale);
    }
}
