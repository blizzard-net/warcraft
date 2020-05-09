using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsJournalApi
    {
        [Fact]
        public async void GetAchievementCategoriesIndexAsync_Gets_AchievementCategoriesIndex()
        {
            IWarcraftClientJournalApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/journal-expansion/index?namespace=static-us&locale=en_US",
                responseContent: Resources.JournalExpansionsIndexResponse);

            RequestResult<JournalExpansionsIndex> result = await warcraftClient.GetJournalExpansionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }
    }
}
