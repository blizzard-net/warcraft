using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PlayableSpecializationApiTests
    {
        [ResilientFact]
        public async Task GetPlayableSpecializationsIndexAsync_Gets_PlayableSpecializationsIndex()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableSpecializationsIndex> result = await warcraftClient.GetPlayableSpecializationsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPlayableSpecializationAsync_Gets_PlayableSpecialization()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableSpecialization> result = await warcraftClient.GetPlayableSpecializationAsync(262, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPlayableSpecializationMediaAsync_Gets_PlayableSpecializationMedia()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableSpecializationMedia> result = await warcraftClient.GetPlayableSpecializationMediaAsync(262, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
