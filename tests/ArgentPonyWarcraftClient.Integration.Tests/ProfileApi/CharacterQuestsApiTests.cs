using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterQuestsApiTests
{
    [ResilientFact]
    public async Task GetCharacterQuestsAsync_Gets_CharacterQuests()
    {
        ICharacterQuestsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterQuests> result = await warcraftClient.GetCharacterQuestsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterCompletedQuestsAsync_Gets_CharacterCompletedQuests()
    {
        ICharacterQuestsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterCompletedQuests> result = await warcraftClient.GetCharacterCompletedQuestsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
