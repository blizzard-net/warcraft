using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PlayableClassApiTests
    {
        [ResilientFact]
        public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPlayableClassAsync_Gets_PlayableClass()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpTalentSlotsAsync_Gets_PvpTalentSlots()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTalentSlots> result = await warcraftClient.GetPvpTalentSlotsAsync(7, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
