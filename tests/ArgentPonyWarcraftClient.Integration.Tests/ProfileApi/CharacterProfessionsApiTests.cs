using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterProfessionsApiTests
{
    [ResilientFact]
    public async Task GetCharacterProfessionsSummaryAsync_Gets_CharacterProfessionsSummary()
    {
        ICharacterProfessionsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterProfessionsSummary> result = await warcraftClient.GetCharacterProfessionsSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
