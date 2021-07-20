using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class WowTokenApiTests
    {
        [ResilientFact]
        public async Task GetWowTokenIndexAsync_Gets_WowTokenIndex()
        {
            IWowTokenApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<WowTokenIndex> result = await warcraftClient.GetWowTokenIndexAsync("dynamic-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/token/index?namespace=dynamic-us&locale=en_US");
        }
    }
}
