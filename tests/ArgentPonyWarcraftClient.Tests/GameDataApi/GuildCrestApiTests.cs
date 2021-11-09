namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class GuildCrestApiTests
{
    [Fact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild-crest/index?namespace=static-us&locale=en_US",
            responseContent: Resources.GuildCrestComponentsIndexResponse);

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/guild-crest/border/0?namespace=static-us&locale=en_US",
            responseContent: Resources.GuildCrestBorderMediaResponse);

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/guild-crest/emblem/0?namespace=static-us&locale=en_US",
            responseContent: Resources.GuildCrestEmblemMediaResponse);

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, "static-us");
        Assert.NotNull(result.Value);
    }
}
