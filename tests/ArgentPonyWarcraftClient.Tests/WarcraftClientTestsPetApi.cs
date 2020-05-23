using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsPetApi
    {
        [Fact]
        public async void GetPetsIndexAsync_Gets_PetsIndex()
        {
            IWarcraftClientPetApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/pet/index?namespace=static-us&locale=en_US",
                responseContent: Resources.PetsIndexResponse);

            RequestResult<PetsIndex> result = await warcraftClient.GetPetsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }
    }
}
