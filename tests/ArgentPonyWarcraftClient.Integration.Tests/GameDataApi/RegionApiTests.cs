using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class RegionApiTests
    {
        [ResilientFact]
        public async void GetRegionsIndexAsync_Gets_RegionsIndex()
        {
            IRegionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<RegionsIndex> result = await warcraftClient.GetRegionsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetRegionAsync_Gets_Region()
        {
            IRegionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<RegionData> result = await warcraftClient.GetRegionAsync(1, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
