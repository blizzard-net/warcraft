using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class MythicKeystoneLeaderboardApiTests
{
    [Fact]
    public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
    {
        IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/11/mythic-leaderboard/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneLeaderboardsIndexResponse);

        RequestResult<MythicKeystoneLeaderboardsIndex> result = await warcraftClient.GetMythicKeystoneLeaderboardsIndexAsync(11, "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneLeaderboard_Gets_MythicKeystoneLeaderboard()
    {
        IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/11/mythic-leaderboard/197/period/641?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneLeaderboardResponse);

        RequestResult<MythicKeystoneLeaderboard> result = await warcraftClient.GetMythicKeystoneLeaderboard(11, 197, 641, "dynamic-us");
        Assert.NotNull(result.Value);
    }
}
