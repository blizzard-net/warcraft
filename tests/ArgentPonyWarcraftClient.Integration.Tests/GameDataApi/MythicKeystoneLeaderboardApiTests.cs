using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicKeystoneLeaderboardApiTests
    {
        [ResilientFact]
        public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<MythicKeystoneLeaderboardsIndex> result = await warcraftClient.GetMythicKeystoneLeaderboardsIndexAsync(11, "dynamic-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/11/mythic-leaderboard/index?namespace=dynamic-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetMythicKeystoneLeaderboard_Gets_MythicKeystoneLeaderboard()
        {
            IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<MythicKeystoneLeaderboard> result = await warcraftClient.GetMythicKeystoneLeaderboard(11, 197, 641, "dynamic-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/11/mythic-leaderboard/197/period/641?namespace=dynamic-us&locale=en_US");
        }
    }
}
