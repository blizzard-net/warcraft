using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class RealmApiTests
    {
        [ResilientFact]
        public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetRealmAsync_Gets_Realm()
        {
            IRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Realm> result = await warcraftClient.GetRealmAsync("tichondrius", "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
