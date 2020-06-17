using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class PetApiTests
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

        [Fact]
        public async void GetPetAsync_Gets_Pet()
        {
            IWarcraftClientPetApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/pet/39?namespace=static-us&locale=en_US",
                responseContent: Resources.PetResponse);

            RequestResult<Pet> result = await warcraftClient.GetPetAsync(39, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
