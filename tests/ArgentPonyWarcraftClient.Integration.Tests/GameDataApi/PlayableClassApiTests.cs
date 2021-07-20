using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PlayableClassApiTests
    {
        [ResilientFact]
        public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-class/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetPlayableClassAsync_Gets_PlayableClass()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-class/7?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/playable-class/7?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetPvpTalentSlotsAsync_Gets_PvpTalentSlots()
        {
            IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<PvpTalentSlots> result = await warcraftClient.GetPvpTalentSlotsAsync(7, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/playable-class/7/pvp-talent-slots?namespace=static-us&locale=en_US");
        }
    }
}
