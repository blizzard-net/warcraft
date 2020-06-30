using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class CharacterAchievementsApiTests
    {
        [Fact]
        public async void GetCharacterAchievementsSummaryAsync_Gets_CharacterAchievementsSummary()
        {
            IWarcraftClientCharacterAchievementsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/achievements?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterAchievementsSummaryResponse);

            RequestResult<CharacterAchievementsSummary> result = await warcraftClient.GetCharacterAchievementsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterAchievementStatisticsAsync_Gets_CharacterAchievementStatistics()
        {
            IWarcraftClientCharacterAchievementsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/achievements/statistics?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterAchievementStatisticsResponse);

            RequestResult<CharacterAchievementStatistics> result = await warcraftClient.GetCharacterAchievementStatisticsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
