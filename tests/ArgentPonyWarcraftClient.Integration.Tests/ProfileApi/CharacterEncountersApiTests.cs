using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterEncountersApiTests
{
    [ResilientFact]
    public async Task GetCharacterEncountersSummaryAsync_Gets_CharacterEncountersSummary()
    {
        ICharacterEncountersApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterEncountersSummary> result = await warcraftClient.GetCharacterEncountersSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterDungeonsAsync_Gets_CharacterDungeons()
    {
        ICharacterEncountersApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterDungeons> result = await warcraftClient.GetCharacterDungeonsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterRaidsAsync_Gets_CharacterRaids()
    {
        ICharacterEncountersApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterRaids> result = await warcraftClient.GetCharacterRaidsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
