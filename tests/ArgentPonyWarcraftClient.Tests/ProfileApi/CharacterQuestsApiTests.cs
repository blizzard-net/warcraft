using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class CharacterQuestsApiTests
{
    [Fact]
    public async Task GetCharacterQuestsAsync_Gets_CharacterQuests()
    {
        ICharacterQuestsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/quests?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterQuestsResponse);

        RequestResult<CharacterQuests> result = await warcraftClient.GetCharacterQuestsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCharacterCompletedQuestsAsync_Gets_CharacterCompletedQuests()
    {
        ICharacterQuestsApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/quests/completed?namespace=profile-us&locale=en_US",
            responseContent: Resources.CharacterCompletedQuestsResponse);

        RequestResult<CharacterCompletedQuests> result = await warcraftClient.GetCharacterCompletedQuestsAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
