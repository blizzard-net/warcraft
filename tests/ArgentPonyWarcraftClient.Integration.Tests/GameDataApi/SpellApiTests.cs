using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class SpellApiTests
{
    [ResilientFact]
    public async Task GetSpellAsync_Gets_Spell()
    {
        ISpellApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Spell> result = await warcraftClient.GetSpellAsync(196607, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/spell/196607?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetSpellMediaAsync_Gets_SpellMedia()
    {
        ISpellApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<SpellMedia> result = await warcraftClient.GetSpellMediaAsync(196607, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/spell/196607?namespace=static-us&locale=en_US");
    }
}
