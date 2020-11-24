using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PvpSeasonApiTests
    {
        [ResilientFact]
        public async Task GetPvpSeasonsIndexAsync_Gets_PvpSeasonsIndex()
        {
            IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpSeasonsIndex> result = await warcraftClient.GetPvpSeasonsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpSeasonAsync_Gets_PvpSeason()
        {
            IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpSeason> result = await warcraftClient.GetPvpSeasonAsync(27, "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpLeaderboardsIndexAsync_Gets_PvpLeaderboardsIndex()
        {
            IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpLeaderboardsIndex> result = await warcraftClient.GetPvpLeaderboardsIndexAsync(27, "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpLeaderboardAsync_Gets_PvpLeaderboard()
        {
            IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync(27, "3v3", "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpRewardsIndexAsync_Gets_PvpRewardsIndex()
        {
            IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpRewardsIndex> result = await warcraftClient.GetPvpRewardsIndexAsync(27, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
