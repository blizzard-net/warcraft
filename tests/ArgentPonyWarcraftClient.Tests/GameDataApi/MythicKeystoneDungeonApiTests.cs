namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class MythicKeystoneDungeonApiTests
{
    [Fact]
    public async Task GetMythicKeystoneDungeonsIndexAsync_Gets_MythicKeystoneDungeonsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/dungeon/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneDungeonsIndexResponse);

        RequestResult<MythicKeystoneDungeonsIndex> result = await warcraftClient.GetMythicKeystoneDungeonsIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneDungeonAsync_Gets_MythicKeystoneDungeon()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/dungeon/353?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneDungeonResponse);

        RequestResult<MythicKeystoneDungeon> result = await warcraftClient.GetMythicKeystoneDungeonAsync(353, "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneIndexAsync_Gets_MythicKeystoneIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneIndexResponse);

        RequestResult<MythicKeystoneIndex> result = await warcraftClient.GetMythicKeystoneIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystonePeriodsIndexAsync_Gets_MythicKeystonePeriodsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/period/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystonePeriodsIndexResponse);

        RequestResult<MythicKeystonePeriodsIndex> result = await warcraftClient.GetMythicKeystonePeriodsIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystonePeriodAsync_Gets_MythicKeystonePeriod()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/period/641?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystonePeriodResponse);

        RequestResult<MythicKeystonePeriod> result = await warcraftClient.GetMythicKeystonePeriodAsync(641, "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneSeasonsIndexAsync_Gets_MythicKeystoneSeasonsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/season/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneSeasonsIndexResponse);

        RequestResult<MythicKeystoneSeasonsIndex> result = await warcraftClient.GetMythicKeystoneSeasonsIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneSeasonAsync_Gets_MythicKeystoneSeason()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mythic-keystone/season/1?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.MythicKeystoneSeasonResponse);

        RequestResult<MythicKeystoneSeason> result = await warcraftClient.GetMythicKeystoneSeasonAsync(1, "dynamic-us");
        Assert.NotNull(result.Value);
    }
}
