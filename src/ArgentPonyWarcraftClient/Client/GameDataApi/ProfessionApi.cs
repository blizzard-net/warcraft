namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace)
    {
        return await GetProfessionsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ProfessionsIndex>($"{host}/data/wow/profession/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace)
    {
        return await GetProfessionAsync(professionId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Profession>($"{host}/data/wow/profession/{professionId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace)
    {
        return await GetProfessionMediaAsync(professionId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<ProfessionMedia>($"{host}/data/wow/media/profession/{professionId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace)
    {
        return await GetSkillTierAsync(professionId, skillTierId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<SkillTier>($"{host}/data/wow/profession/{professionId}/skill-tier/{skillTierId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace)
    {
        return await GetRecipeAsync(recipeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Recipe>($"{host}/data/wow/recipe/{recipeId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace)
    {
        return await GetRecipeMediaAsync(recipeId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<RecipeMedia>($"{host}/data/wow/media/recipe/{recipeId}?namespace={@namespace}&locale={locale}");
    }
}
