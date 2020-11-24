using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PowerTypeApiTests
    {
        [ResilientFact]
        public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex()
        {
            IPowerTypeApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPowerTypeAsync_Gets_PowerType()
        {
            IPowerTypeApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
