using System.Threading.Tasks;

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

        /// <inheritdoc />
        public async Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace)
        {
            return await GetAchievementsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementsIndex>> GetAchievementsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AchievementsIndex>(region, $"{host}/data/wow/achievement/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace)
        {
            return await GetAchievementAsync(achievementId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Achievement>(region, $"{host}/data/wow/achievement/{achievementId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace)
        {
            return await GetAchievementMediaAsync(achievementId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<AchievementMedia>> GetAchievementMediaAsync(int achievementId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AchievementMedia>(region, $"{host}/data/wow/media/achievement/{achievementId}?namespace={@namespace}&locale={locale}");
        }
    }
}
