using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterMediaApiTests
{
    [ResilientFact]
    public async Task GetCharacterMediaSummaryAsync_Gets_CharacterMediaSummary()
    {
        ICharacterMediaApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterMediaSummary> result = await warcraftClient.GetCharacterMediaSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
