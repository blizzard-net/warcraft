using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ReputationFactionApiTests
    {
        [ResilientFact]
        public async Task GetReputationFactionsIndexAsync_Gets_ReputationFactionsIndex()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ReputationFactionsIndex> result = await warcraftClient.GetReputationFactionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetReputationFactionAsync_Gets_ReputationFaction()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ReputationFaction> result = await warcraftClient.GetReputationFactionAsync(21, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetReputationTiersIndexAsync_Gets_ReputationTiersIndex()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ReputationTiersIndex> result = await warcraftClient.GetReputationTiersIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetReputationTiersAsync_Gets_ReputationTiers()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ReputationTiers> result = await warcraftClient.GetReputationTiersAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
