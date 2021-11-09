using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class RegionApiTests
{
    [Fact]
    public async Task GetRegionsIndexAsync_Gets_RegionsIndex()
    {
        IRegionApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/region/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.RegionsIndexResponse);

        RequestResult<RegionsIndex> result = await warcraftClient.GetRegionsIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRegionAsync_Gets_Region()
    {
        IRegionApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/region/1?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.RegionResponse);

        RequestResult<RegionData> result = await warcraftClient.GetRegionAsync(1, "dynamic-us");
        Assert.NotNull(result.Value);
    }
}
