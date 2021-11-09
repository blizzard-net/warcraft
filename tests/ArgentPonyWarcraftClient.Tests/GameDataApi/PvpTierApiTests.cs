using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class PvpTierApiTests
{
    [Fact]
    public async Task GetPvpTiersIndexAsync_Gets_PvpTiersIndex()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-tier/index?namespace=static-us&locale=en_US",
            responseContent: Resources.PvpTiersIndexResponse);

        RequestResult<PvpTiersIndex> result = await warcraftClient.GetPvpTiersIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpTierAsync_Gets_PvpTier()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-tier/1?namespace=static-us&locale=en_US",
            responseContent: Resources.PvpTierResponse);

        RequestResult<PvpTier> result = await warcraftClient.GetPvpTierAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpTierMediaAsync_Gets_PvpTierMedia()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/pvp-tier/1?namespace=static-us&locale=en_US",
            responseContent: Resources.PvpTierMediaResponse);

        RequestResult<PvpTierMedia> result = await warcraftClient.GetPvpTierMediaAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }
}
