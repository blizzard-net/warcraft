using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterStatisticsApiTests
{
    [Fact]
    public async Task GetCharacterStatisticsSummaryAsync_Gets_CharacterStatisticsSummary()
    {
        ICharacterStatisticsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/statistics?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterStatisticsSummaryResponse);

        RequestResult<CharacterStatisticsSummary> result = await warcraftClient.GetCharacterStatisticsSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
