using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class AzeriteEssenceApiTests
    {
        [Fact]
        public async void GetAzeriteEssencesIndexAsync_Gets_AzeriteEssencesIndex()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/azerite-essence/index?namespace=static-us&locale=en_US",
                responseContent: Resources.AzeriteEssencesIndexResponse);

            RequestResult<AzeriteEssencesIndex> result = await warcraftClient.GetAzeriteEssencesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAzeriteEssenceAsync_Gets_AzeriteEssence()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/azerite-essence/2?namespace=static-us&locale=en_US",
                responseContent: Resources.AzeriteEssenceResponse);

            RequestResult<AzeriteEssence> result = await warcraftClient.GetAzeriteEssenceAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAzeriteEssenceMediaAsync_Gets_AzeriteEssenceMedia()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/azerite-essence/2?namespace=static-us&locale=en_US",
                responseContent: Resources.AzeriteEssenceMediaResponse);

            RequestResult<AzeriteEssenceMedia> result = await warcraftClient.GetAzeriteEssenceMediaAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
