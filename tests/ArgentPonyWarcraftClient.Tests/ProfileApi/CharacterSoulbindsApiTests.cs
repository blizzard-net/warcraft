namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterSoulbindsApiTests
{
    [Fact]
    public async Task GetCharacterSoulbindsAsync_Gets_CharacterSoulbinds()
    {
        ICharacterSoulbindsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/ravencrest/drizzy/soulbinds?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterSoulbindsResponse);

        RequestResult<CharacterSoulbinds> result = await warcraftClient.GetCharacterSoulbindsAsync("ravencrest", "drizzy", "profile-us");
        Assert.NotNull(result.Value);
    }
}
