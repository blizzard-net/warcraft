using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class AuctionHouseApiTests
    {
        [ResilientFact]
        public async void GetAuctionsAsync_Gets_Auctions()
        {
            IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(1146, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
