using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class RealmApiTests
    {
        [Fact]
        public async void GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IRealmApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/realm/index?namespace=dynamic-us&locale=en_US",
                responseContent: Resources.RealmIndexResponse);

            RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRealmAsync_Gets_Realm()
        {
            IRealmApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/realm/tichondrius?namespace=dynamic-us&locale=en_US",
                responseContent: Resources.RealmResponse);

            RequestResult<Realm> result = await warcraftClient.GetRealmAsync("tichondrius", "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
