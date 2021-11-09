using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterReputationsApiTests
{
    [Fact]
    public async Task GetCharacterReputationsSummaryAsync_Gets_CharacterReputationsSummary()
    {
        ICharacterReputationsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/reputations?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterReputationsSummaryResponse);

        RequestResult<CharacterReputationsSummary> result = await warcraftClient.GetCharacterReputationsSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
