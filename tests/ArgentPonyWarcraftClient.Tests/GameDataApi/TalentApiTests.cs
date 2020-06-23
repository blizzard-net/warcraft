using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class TalentApiTests
    {
        [Fact]
        public async void GetTalentsIndexAsync_Gets_TalentsIndex()
        {
            IWarcraftClientTalentApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/talent/index?namespace=static-us&locale=en_US",
                responseContent: Resources.TalentsIndexResponse);

            RequestResult<TalentsIndex> result = await warcraftClient.GetTalentsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetTalentAsync_Gets_Talent()
        {
            IWarcraftClientTalentApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/talent/23106?namespace=static-us&locale=en_US",
                responseContent: Resources.TalentResponse);

            RequestResult<Talent> result = await warcraftClient.GetTalentAsync(23106, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPvpTalentsIndexAsync_Gets_PvpTalentsIndex()
        {
            IWarcraftClientTalentApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/pvp-talent/index?namespace=static-us&locale=en_US",
                responseContent: Resources.PvpTalentsIndexResponse);

            RequestResult<PvpTalentsIndex> result = await warcraftClient.GetPvpTalentsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPvpTalentAsync_Gets_PvpTalent()
        {
            IWarcraftClientTalentApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/pvp-talent/3?namespace=static-us&locale=en_US",
                responseContent: Resources.PvpTalentResponse);

            RequestResult<PvpTalent> result = await warcraftClient.GetPvpTalentAsync(3, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
