namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class PvpTierApiTests
{
    [ResilientFact]
    public async Task GetPvpTiersIndexAsync_Gets_PvpTiersIndex()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpTiersIndex> result = await warcraftClient.GetPvpTiersIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-tier/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpTierAsync_Gets_PvpTier()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpTier> result = await warcraftClient.GetPvpTierAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-tier/1?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpTierMediaAsync_Gets_PvpTierMedia()
    {
        IPvpTierApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpTierMedia> result = await warcraftClient.GetPvpTierMediaAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/pvp-tier/1?namespace=static-us&locale=en_US");
    }
}
