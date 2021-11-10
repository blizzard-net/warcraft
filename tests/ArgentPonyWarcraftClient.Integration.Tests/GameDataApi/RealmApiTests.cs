namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class RealmApiTests
{
    [ResilientFact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/realm/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Realm> result = await warcraftClient.GetRealmAsync("tichondrius", "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/realm/tichondrius?namespace=dynamic-us&locale=en_US");
    }
}
