using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicKeystoneLeaderboardApiTests
    {
        [ResilientFact]
        public async void GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneLeaderboardsIndex> result = await warcraftClient.GetMythicKeystoneLeaderboardsIndexAsync(11, "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystoneLeaderboard_Gets_MythicKeystoneLeaderboard()
        {
            IMythicKeystoneLeaderboardApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneLeaderboard> result = await warcraftClient.GetMythicKeystoneLeaderboard(11, 197, 641, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
