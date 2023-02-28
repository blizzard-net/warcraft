using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterPvpApiTests
{
    [ResilientFact]
    public async Task GetCharacterPvpBracketStatisticsAsync_Gets_PvpBracketStatistics()
    {
        ICharacterPvpApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterPvpBracketStatistics> result = await warcraftClient.GetCharacterPvpBracketStatisticsAsync("malganis", "gutso", "3v3", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterPvpSummaryAsync_Gets_CharacterPvpSummary()
    {
        ICharacterPvpApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterPvpSummary> result = await warcraftClient.GetCharacterPvpSummaryAsync("malganis", "gutso", "profile-us");
        Assert.NotNull(result.Value);
    }
}
