namespace ArgentPonyWarcraftClient;

/// <summary>
///     A client for the World of Warcraft Profession API.
/// </summary>
public interface IProfessionApi
{
    /// <summary>
    ///     Gets an index of professions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The profession index.
    /// </returns>
    Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace);

    /// <summary>
    ///     Gets an index of professions.
    /// </summary>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The profession index.
    /// </returns>
    Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified profession.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified profession.
    /// </returns>
    Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace);

    /// <summary>
    ///     Get the specified profession.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified profession.
    /// </returns>
    Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a profession by ID.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a profession by ID.
    /// </returns>
    Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace);

    /// <summary>
    ///     Get media for a profession by ID.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a profession by ID.
    /// </returns>
    Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified skill tier.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="skillTierId">The ID of the skill tier.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified skill tier.
    /// </returns>
    Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace);

    /// <summary>
    ///     Get the specified skill tier.
    /// </summary>
    /// <param name="professionId">The profession ID.</param>
    /// <param name="skillTierId">The ID of the skill tier.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified skill tier.
    /// </returns>
    Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get the specified recipe.
    /// </summary>
    /// <param name="recipeId">The recipe ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The specified recipe.
    /// </returns>
    Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace);

    /// <summary>
    ///     Get the specified recipe.
    /// </summary>
    /// <param name="recipeId">The recipe ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The specified recipe.
    /// </returns>
    Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Get media for a recipe by ID.
    /// </summary>
    /// <param name="recipeId">The recipe ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     Media for a recipe by ID.
    /// </returns>
    Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace);

    /// <summary>
    ///     Get media for a recipe by ID.
    /// </summary>
    /// <param name="recipeId">The recipe ID.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     Media for a recipe by ID.
    /// </returns>
    Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace, Region region, Locale locale);
}
