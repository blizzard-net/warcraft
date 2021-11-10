namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class PetApiTests
{
    [Fact]
    public async Task GetPetsIndexAsync_Gets_PetsIndex()
    {
        IPetApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pet/index?namespace=static-us&locale=en_US",
            responseContent: Resources.PetsIndexResponse);

        RequestResult<PetsIndex> result = await warcraftClient.GetPetsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPetAsync_Gets_Pet()
    {
        IPetApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pet/39?namespace=static-us&locale=en_US",
            responseContent: Resources.PetResponse);

        RequestResult<Pet> result = await warcraftClient.GetPetAsync(39, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPetAbilitiesIndexAsync_Gets_PetAbilitiesIndex()
    {
        IPetApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pet-ability/index?namespace=static-us&locale=en_US",
            responseContent: Resources.PetAbilitiesIndexResponse);

        RequestResult<PetAbilitiesIndex> result = await warcraftClient.GetPetAbilitiesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPetAbilityAsync_Gets_PetAbility()
    {
        IPetApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pet-ability/110?namespace=static-us&locale=en_US",
            responseContent: Resources.PetAbilityResponse);

        RequestResult<PetAbility> result = await warcraftClient.GetPetAbilityAsync(110, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPetAbilityMediaAsync_Gets_PetAbilityMedia()
    {
        IPetApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/pet-ability/110?namespace=static-us&locale=en_US",
            responseContent: Resources.PetAbilityMediaResponse);

        RequestResult<PetAbilityMedia> result = await warcraftClient.GetPetAbilityMediaAsync(110, "static-us");
        Assert.NotNull(result.Value);
    }
}
