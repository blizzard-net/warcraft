using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace)
        {
            return await GetQuestsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestsIndex>> GetQuestsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestsIndex>(region, $"{host}/data/wow/quest/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace)
        {
            return await GetQuestAsync(questId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Quest>(region, $"{host}/data/wow/quest/{questId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace)
        {
            return await GetQuestCategoriesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestCategoriesIndex>> GetQuestCategoriesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestCategoriesIndex>(region, $"{host}/data/wow/quest/category/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace)
        {
            return await GetQuestCategoryAsync(questCategoryId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestCategory>> GetQuestCategoryAsync(int questCategoryId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestCategory>(region, $"{host}/data/wow/quest/category/{questCategoryId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace)
        {
            return await GetQuestAreasIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestAreasIndex>> GetQuestAreasIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestAreasIndex>(region, $"{host}/data/wow/quest/area/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace)
        {
            return await GetQuestAreaAsync(questAreaId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestArea>> GetQuestAreaAsync(int questAreaId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestArea>(region, $"{host}/data/wow/quest/area/{questAreaId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace)
        {
            return await GetQuestTypesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestTypesIndex>> GetQuestTypesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestTypesIndex>(region, $"{host}/data/wow/quest/type/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace)
        {
            return await GetQuestTypeAsync(questTypeId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<QuestType>> GetQuestTypeAsync(int questTypeId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<QuestType>(region, $"{host}/data/wow/quest/type/{questTypeId}?namespace={@namespace}&locale={locale}");
        }
    }
}
