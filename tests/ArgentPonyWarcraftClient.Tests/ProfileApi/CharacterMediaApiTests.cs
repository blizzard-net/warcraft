using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterMediaApiTests
{
    [Fact]
    public async Task GetCharacterMediaSummaryAsync_Gets_CharacterMediaSummary()
    {
        ICharacterMediaApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/character-media?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterMediaSummaryResponse);

        RequestResult<CharacterMediaSummary> result = await warcraftClient.GetCharacterMediaSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
