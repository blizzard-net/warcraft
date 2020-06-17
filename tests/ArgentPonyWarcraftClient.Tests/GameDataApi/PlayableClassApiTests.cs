using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class PlayableClassApiTests
    {
        [Fact]
        public async void GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex()
        {
            IWarcraftClientPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/playable-class/index?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableClassesIndexResponse);

            RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableClassAsync_Gets_PlayableClass()
        {
            IWarcraftClientPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/playable-class/7?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableClassResponse);

            RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableClassMediaAsync_Gets_PlayableClassMedia()
        {
            IWarcraftClientPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/playable-class/7?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableClassMediaResponse);

            RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPvpTalentSlotsAsync_Gets_PvpTalentSlots()
        {
            IWarcraftClientPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/playable-class/7/pvp-talent-slots?namespace=static-us&locale=en_US",
                responseContent: Resources.PvpTalentSlotsResponse);

            RequestResult<PvpTalentSlots> result = await warcraftClient.GetPvpTalentSlotsAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
