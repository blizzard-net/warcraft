using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class AuctionHouseApiTests
    {
        [Fact]
        public async Task GetAuctionsAsync_Gets_Auctions()
        {
            IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/4/auctions?namespace=dynamic-us&locale=en_US",
                responseContent: Resources.AuctionsResponse);

            RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(4, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
