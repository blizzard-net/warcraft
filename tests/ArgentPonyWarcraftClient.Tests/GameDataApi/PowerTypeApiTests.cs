using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class PowerTypeApiTests
    {
        [Fact]
        public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex()
        {
            IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/power-type/index?namespace=static-us&locale=en_US",
                responseContent: Resources.PowerTypesIndexResponse);

            RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetPowerTypeAsync_Gets_PowerType()
        {
            IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/power-type/0?namespace=static-us&locale=en_US",
                responseContent: Resources.PowerTypeResponse);

            RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
