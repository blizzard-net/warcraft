using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class ReputationFactionApiTests
    {
        [Fact]
        public async void GetReputationFactionsIndexAsync_Gets_ReputationFactionsIndex()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/reputation-faction/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ReputationFactionsIndexResponse);

            RequestResult<ReputationFactionsIndex> result = await warcraftClient.GetReputationFactionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetReputationFactionAsync_Gets_ReputationFaction()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/reputation-faction/21?namespace=static-us&locale=en_US",
                responseContent: Resources.ReputationFactionResponse);

            RequestResult<ReputationFaction> result = await warcraftClient.GetReputationFactionAsync(21, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetReputationTiersIndexAsync_Gets_ReputationTiersIndex()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/reputation-tiers/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ReputationTiersIndexResponse);

            RequestResult<ReputationTiersIndex> result = await warcraftClient.GetReputationTiersIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetReputationTiersAsync_Gets_ReputationTiers()
        {
            IReputationsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/reputation-tiers/2?namespace=static-us&locale=en_US",
                responseContent: Resources.ReputationTiersResponse);

            RequestResult<ReputationTiers> result = await warcraftClient.GetReputationTiersAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
