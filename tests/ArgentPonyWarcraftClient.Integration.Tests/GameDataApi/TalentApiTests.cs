namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class TalentApiTests
{
    [ResilientFact]
    public async Task GetTalentsIndexAsync_Gets_TalentsIndex()
    {
        ITalentApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<TalentsIndex> result = await warcraftClient.GetTalentsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/talent/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetTalentAsync_Gets_Talent()
    {
        ITalentApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Talent> result = await warcraftClient.GetTalentAsync(117163, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/talent/117163?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpTalentsIndexAsync_Gets_PvpTalentsIndex()
    {
        ITalentApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpTalentsIndex> result = await warcraftClient.GetPvpTalentsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-talent/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpTalentAsync_Gets_PvpTalent()
    {
        ITalentApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpTalent> result = await warcraftClient.GetPvpTalentAsync(11, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-talent/11?namespace=static-us&locale=en_US");
    }
}
