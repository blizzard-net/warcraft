using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class MythicRaidLeaderboardApiTests
    {
        [Fact]
        public async void GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicRaidLeaderboardApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/leaderboard/hall-of-fame/uldir/alliance?namespace=dynamic-us&locale=en_US",
                responseContent: Resources.MythicRaidLeaderboardResponse);

            RequestResult<MythicRaidLeaderboard> result = await warcraftClient.GetMythicRaidLeaderboardAsync("uldir", "alliance", "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
