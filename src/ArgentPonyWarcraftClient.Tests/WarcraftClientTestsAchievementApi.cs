using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsAchievementApi
    {
        [Fact]
        public async void GetAchievementCategoriesIndexAsync_Gets_AchievementCategoriesIndex()
        {
            IWarcraftClientAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/achievement-category/index?namespace=static-us&locale=en_US",
                responseContent: Resources.AchievementCategoriesIndexResponse);

            RequestResult<AchievementCategoriesIndex> result = await warcraftClient.GetAchievementCategoriesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }
    }
}
