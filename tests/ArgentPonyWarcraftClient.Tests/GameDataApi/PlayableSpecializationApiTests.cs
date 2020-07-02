using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class PlayableSpecializationApiTests
    {
        [Fact]
        public async void GetPlayableSpecializationsIndexAsync_Gets_PlayableSpecializationsIndex()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/playable-specialization/index?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableSpecializationsIndexResponse);

            RequestResult<PlayableSpecializationsIndex> result = await warcraftClient.GetPlayableSpecializationsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableSpecializationAsync_Gets_PlayableSpecialization()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/playable-specialization/262?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableSpecializationResponse);

            RequestResult<PlayableSpecialization> result = await warcraftClient.GetPlayableSpecializationAsync(262, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableSpecializationMediaAsync_Gets_PlayableSpecializationMedia()
        {
            IPlayableSpecializationApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/playable-specialization/262?namespace=static-us&locale=en_US",
                responseContent: Resources.PlayableSpecializationMediaResponse);

            RequestResult<PlayableSpecializationMedia> result = await warcraftClient.GetPlayableSpecializationMediaAsync(262, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
