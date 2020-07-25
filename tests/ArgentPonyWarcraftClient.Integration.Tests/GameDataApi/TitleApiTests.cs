using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class TitleApiTests
    {
        [ResilientFact]
        public async void GetTitlesIndexAsync_Gets_TitlesIndex()
        {
            ITitleApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<TitlesIndex> result = await warcraftClient.GetTitlesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetTitleAsync_Gets_Title()
        {
            ITitleApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Title> result = await warcraftClient.GetTitleAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
