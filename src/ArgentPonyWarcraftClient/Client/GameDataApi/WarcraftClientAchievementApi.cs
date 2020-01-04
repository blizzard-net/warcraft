using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace)
        {
            return await GetAchievementCategoriesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementCategoriesIndex>> GetAchievementCategoriesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AchievementCategoriesIndex>(region, $"{host}/data/wow/achievement-category/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace)
        {
            return await GetAchievementCategoryAsync(achievementCategoryId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AchievementCategory>(region, $"{host}/data/wow/achievement-category/{achievementCategoryId}?namespace={@namespace}&locale={locale}");
        }
    }
}
