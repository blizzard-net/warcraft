namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class TitleApiTests
{
    [ResilientFact]
    public async Task GetTitlesIndexAsync_Gets_TitlesIndex()
    {
        ITitleApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<TitlesIndex> result = await warcraftClient.GetTitlesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
                        .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/title/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetTitleAsync_Gets_Title()
    {
        ITitleApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Title> result = await warcraftClient.GetTitleAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
                        .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/title/1?namespace=static-us&locale=en_US");
    }
}
