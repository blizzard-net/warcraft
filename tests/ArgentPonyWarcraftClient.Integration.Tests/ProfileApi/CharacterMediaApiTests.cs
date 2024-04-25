using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterMediaApiTests
{
    [ResilientFact(Skip = "Currently returning 403 Forbidden, BLZWEBAPI00000403. Need to investigate.")]
    public async Task GetCharacterMediaSummaryAsync_Gets_CharacterMediaSummary()
    {
        ICharacterMediaApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterMediaSummary> result = await warcraftClient.GetCharacterMediaSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
