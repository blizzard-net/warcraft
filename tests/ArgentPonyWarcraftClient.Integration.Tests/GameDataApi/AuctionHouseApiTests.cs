using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class AuctionHouseApiTests
{
    [ResilientFact]
    public async Task GetAuctionsAsync_Gets_Auctions()
    {
        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(4, "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/4/auctions?namespace=dynamic-us&locale=en_US");
    }
}
