using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterAchievementsApiTests
    {
        [ResilientFact]
        public async void GetCharacterAchievementsSummaryAsync_Gets_CharacterAchievementsSummary()
        {
            ICharacterAchievementsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterAchievementsSummary> result = await warcraftClient.GetCharacterAchievementsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCharacterAchievementStatisticsAsync_Gets_CharacterAchievementStatistics()
        {
            ICharacterAchievementsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterAchievementStatistics> result = await warcraftClient.GetCharacterAchievementStatisticsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
