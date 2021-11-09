using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class ConnectedRealmApiTests
{
    [ResilientFact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(11, "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/11?namespace=dynamic-us&locale=en_US");
    }
}
