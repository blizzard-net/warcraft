using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterAppearanceApiTests
{
    [ResilientFact]
    public async Task GetCharacterAppearanceSummaryAsync_Gets_CharacterAppearanceSummary()
    {
        ICharacterAppearanceApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterAppearanceSummary> result = await warcraftClient.GetCharacterAppearanceSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
