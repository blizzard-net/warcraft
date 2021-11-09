using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class MythicRaidLeaderboardApiTests
{
    [ResilientFact]
    public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
    {
        IMythicRaidLeaderboardApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicRaidLeaderboard> result = await warcraftClient.GetMythicRaidLeaderboardAsync("uldir", "alliance", "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/leaderboard/hall-of-fame/uldir/alliance?namespace=dynamic-us&locale=en_US");
    }
}
