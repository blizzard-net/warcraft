using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class RealmApiTests
    {
        [ResilientFact]
        public async void GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetRealmAsync_Gets_Realm()
        {
            IRealmApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Realm> result = await warcraftClient.GetRealmAsync("tichondrius", "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
