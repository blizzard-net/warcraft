using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class AuctionHouseApiTests
    {
        [ResilientFact]
        public async Task GetAuctionsAsync_Gets_Auctions()
        {
            IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(4, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
