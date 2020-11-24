using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ConnectedRealmApiTests
    {
        [ResilientFact]
        public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetRealmAsync_Gets_Realm()
        {
            IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(11, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
