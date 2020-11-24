using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PvpTierApiTests
    {
        [ResilientFact]
        public async Task GetPvpTiersIndexAsync_Gets_PvpTiersIndex()
        {
            IPvpTierApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTiersIndex> result = await warcraftClient.GetPvpTiersIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpTierAsync_Gets_PvpTier()
        {
            IPvpTierApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTier> result = await warcraftClient.GetPvpTierAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpTierMediaAsync_Gets_PvpTierMedia()
        {
            IPvpTierApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTierMedia> result = await warcraftClient.GetPvpTierMediaAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
