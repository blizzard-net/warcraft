using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class TitleApiTests
{
    [Fact]
    public async Task GetTitlesIndexAsync_Gets_TitlesIndex()
    {
        ITitleApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/title/index?namespace=static-us&locale=en_US",
            responseContent: Resources.TitlesIndexResponse);

        RequestResult<TitlesIndex> result = await warcraftClient.GetTitlesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetTitleAsync_Gets_Title()
    {
        ITitleApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/title/1?namespace=static-us&locale=en_US",
            responseContent: Resources.TitleResponse);

        RequestResult<Title> result = await warcraftClient.GetTitleAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }
}
