using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class AzeriteEssenceApiTests
{
    [ResilientFact]
    public async Task GetAzeriteEssencesIndexAsync_Gets_AzeriteEssencesIndex()
    {
        IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AzeriteEssencesIndex> result = await warcraftClient.GetAzeriteEssencesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/azerite-essence/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAzeriteEssenceAsync_Gets_AzeriteEssence()
    {
        IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AzeriteEssence> result = await warcraftClient.GetAzeriteEssenceAsync(2, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/azerite-essence/2?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAzeriteEssenceMediaAsync_Gets_AzeriteEssenceMedia()
    {
        IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AzeriteEssenceMedia> result = await warcraftClient.GetAzeriteEssenceMediaAsync(2, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/azerite-essence/2?namespace=static-us&locale=en_US");
    }
}
