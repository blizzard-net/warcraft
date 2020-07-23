using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicRaidLeaderboardApiTests
    {
        [ResilientFact]
        public async void GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicRaidLeaderboardApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicRaidLeaderboard> result = await warcraftClient.GetMythicRaidLeaderboardAsync("uldir", "alliance", "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
