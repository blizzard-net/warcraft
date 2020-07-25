using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class AzeriteEssenceApiTests
    {
        [ResilientFact]
        public async void GetAzeriteEssencesIndexAsync_Gets_AzeriteEssencesIndex()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AzeriteEssencesIndex> result = await warcraftClient.GetAzeriteEssencesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetAzeriteEssenceAsync_Gets_AzeriteEssence()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AzeriteEssence> result = await warcraftClient.GetAzeriteEssenceAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetAzeriteEssenceMediaAsync_Gets_AzeriteEssenceMedia()
        {
            IAzeriteEssenceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AzeriteEssenceMedia> result = await warcraftClient.GetAzeriteEssenceMediaAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
