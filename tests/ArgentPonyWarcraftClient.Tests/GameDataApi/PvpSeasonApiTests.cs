namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class PvpSeasonApiTests
{
    [Fact]
    public async Task GetPvpSeasonsIndexAsync_Gets_PvpSeasonsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.PvpSeasonsIndexResponse);

        RequestResult<PvpSeasonsIndex> result = await warcraftClient.GetPvpSeasonsIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpSeasonAsync_Gets_PvpSeason()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/27?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.PvpSeasonResponse);

        RequestResult<PvpSeason> result = await warcraftClient.GetPvpSeasonAsync(27, "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpLeaderboardsIndexAsync_Gets_PvpLeaderboardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/27/pvp-leaderboard/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.PvpLeaderboardsIndexResponse);

        RequestResult<PvpLeaderboardsIndex> result = await warcraftClient.GetPvpLeaderboardsIndexAsync(27, "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpLeaderboardAsync_Gets_PvpLeaderboard()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/27/pvp-leaderboard/3v3?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.PvpLeaderboardResponse);

        RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync(27, "3v3", "dynamic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpRewardsIndexAsync_Gets_PvpRewardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/27/pvp-reward/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.PvpRewardsIndexResponse);

        RequestResult<PvpRewardsIndex> result = await warcraftClient.GetPvpRewardsIndexAsync(27, "dynamic-us");
        Assert.NotNull(result.Value);
    }
}
