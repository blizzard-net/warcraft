using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterTitlesApiTests
{
    [ResilientFact]
    public async Task GetCharacterTitlesSummaryAsync_Gets_CharacterTitlesSummary()
    {
        ICharacterTitlesApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterTitlesSummary> result = await warcraftClient.GetCharacterTitlesSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
