namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class PlayableRaceApiTests
{
    [ResilientFact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-race/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-race/2?namespace=static-us&locale=en_US");
    }
}
