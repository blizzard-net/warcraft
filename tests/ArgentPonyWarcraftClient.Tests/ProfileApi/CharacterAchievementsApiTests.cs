using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterAchievementsApiTests
{
    [Fact]
    public async Task GetCharacterAchievementsSummaryAsync_Gets_CharacterAchievementsSummary()
    {
        ICharacterAchievementsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/achievements?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterAchievementsSummaryResponse);

        RequestResult<CharacterAchievementsSummary> result = await warcraftClient.GetCharacterAchievementsSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCharacterAchievementStatisticsAsync_Gets_CharacterAchievementStatistics()
    {
        ICharacterAchievementsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/achievements/statistics?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterAchievementStatisticsResponse);

        RequestResult<CharacterAchievementStatistics> result = await warcraftClient.GetCharacterAchievementStatisticsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
