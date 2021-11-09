using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterStatisticsApiTests
{
    [ResilientFact]
    public async Task GetCharacterStatisticsSummaryAsync_Gets_CharacterStatisticsSummary()
    {
        ICharacterStatisticsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterStatisticsSummary> result = await warcraftClient.GetCharacterStatisticsSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
