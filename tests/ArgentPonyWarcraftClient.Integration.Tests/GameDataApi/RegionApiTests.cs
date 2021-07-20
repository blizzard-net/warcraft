using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class RegionApiTests
    {
        [ResilientFact]
        public async Task GetRegionsIndexAsync_Gets_RegionsIndex()
        {
            IRegionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<RegionsIndex> result = await warcraftClient.GetRegionsIndexAsync("dynamic-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/region/index?namespace=dynamic-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetRegionAsync_Gets_Region()
        {
            IRegionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<RegionData> result = await warcraftClient.GetRegionAsync(1, "dynamic-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/region/1?namespace=dynamic-us&locale=en_US");
        }
    }
}
