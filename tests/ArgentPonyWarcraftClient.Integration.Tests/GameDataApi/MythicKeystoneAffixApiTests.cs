using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicKeystoneAffixApiTests
    {
        [ResilientFact]
        public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneAffixesIndex> result = await warcraftClient.GetMythicKeystoneAffixesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetMythicKeystoneAffixAsync_Gets_MythicKeystoneAffix()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneAffix> result = await warcraftClient.GetMythicKeystoneAffixAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetMythicKeystoneAffixMediaAsync_Gets_MythicKeystoneAffixMedia()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneAffixMedia> result = await warcraftClient.GetMythicKeystoneAffixMediaAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
