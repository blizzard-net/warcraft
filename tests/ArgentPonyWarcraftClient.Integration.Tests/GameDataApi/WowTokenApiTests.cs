using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class WowTokenApiTests
    {
        [ResilientFact]
        public async Task GetWowTokenIndexAsync_Gets_WowTokenIndex()
        {
            IWowTokenApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<WowTokenIndex> result = await warcraftClient.GetWowTokenIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
