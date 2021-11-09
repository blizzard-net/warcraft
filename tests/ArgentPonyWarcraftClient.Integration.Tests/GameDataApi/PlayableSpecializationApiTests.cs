using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class PlayableSpecializationApiTests
{
    [ResilientFact]
    public async Task GetPlayableSpecializationsIndexAsync_Gets_PlayableSpecializationsIndex()
    {
        IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableSpecializationsIndex> result = await warcraftClient.GetPlayableSpecializationsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-specialization/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPlayableSpecializationAsync_Gets_PlayableSpecialization()
    {
        IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableSpecialization> result = await warcraftClient.GetPlayableSpecializationAsync(262, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-specialization/262?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPlayableSpecializationMediaAsync_Gets_PlayableSpecializationMedia()
    {
        IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableSpecializationMedia> result = await warcraftClient.GetPlayableSpecializationMediaAsync(262, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/playable-specialization/262?namespace=static-us&locale=en_US");
    }
}
