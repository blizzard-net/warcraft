using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class AuctionHouseApiTests
    {
        [Fact]
        public async void GetAuctionsAsync_Gets_Auctions()
        {
            IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/1146/auctions?namespace=dynamic-us&locale=en_US",
                responseContent: Resources.AuctionsResponse);

            RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(1146, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
