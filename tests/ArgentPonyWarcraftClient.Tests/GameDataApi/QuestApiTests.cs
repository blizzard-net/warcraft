using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class QuestApiTests
    {
        [Fact]
        public async Task GetQuestsIndexAsync_Gets_QuestsIndex()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/index?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestsIndexResponse);

            RequestResult<QuestsIndex> result = await warcraftClient.GetQuestsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestAsync_Gets_Quest()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/2?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestResponse);

            RequestResult<Quest> result = await warcraftClient.GetQuestAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestCategoriesIndexAsync_Gets_QuestCategoriesIndex()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/category/index?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestCategoriesIndexResponse);

            RequestResult<QuestCategoriesIndex> result = await warcraftClient.GetQuestCategoriesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestCategoryAsync_Gets_QuestCategory()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/category/1?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestCategoryResponse);

            RequestResult<QuestCategory> result = await warcraftClient.GetQuestCategoryAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestAreasIndexAsync_Gets_QuestAreasIndex()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/area/index?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestAreasIndexResponse);

            RequestResult<QuestAreasIndex> result = await warcraftClient.GetQuestAreasIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestAreaAsync_Gets_QuestArea()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/area/1?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestAreaResponse);

            RequestResult<QuestArea> result = await warcraftClient.GetQuestAreaAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestTypesIndexAsync_Gets_QuestTypesIndex()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/type/index?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestTypesIndexResponse);

            RequestResult<QuestTypesIndex> result = await warcraftClient.GetQuestTypesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetQuestTypeAsync_Gets_QuestType()
        {
            IQuestApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/quest/type/1?namespace=static-us&locale=en_US",
                responseContent: Resources.QuestTypeResponse);

            RequestResult<QuestType> result = await warcraftClient.GetQuestTypeAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
