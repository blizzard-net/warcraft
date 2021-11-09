namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterProfileApiTests
{
    [Fact]
    public async Task GetCharacterProfileSummaryAsync_Gets_CharacterProfileSummary()
    {
        ICharacterProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterProfileSummaryResponse);

        RequestResult<CharacterProfileSummary> result = await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCharacterStatusAsync_Gets_CharacterStatus()
    {
        ICharacterProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/status?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterProfileStatusResponse);

        RequestResult<CharacterStatus> result = await warcraftClient.GetCharacterStatusAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
