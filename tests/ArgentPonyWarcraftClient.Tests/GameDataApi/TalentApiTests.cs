﻿namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class TalentApiTests
{
    [Fact]
    public async Task GetTalentTreeIndexAsync_Gets_TalentTreeIndex()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/talent-tree/index?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentTreeIndexResponse);

        RequestResult<TalentTreeIndex> result = await warcraftClient.GetTalentTreeIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetTalentTreeAsync_Gets_TalentTree()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/talent-tree/786/playable-specialization/262?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentTreeResponse);

        RequestResult<TalentTree> result = await warcraftClient.GetTalentTreeAsync(786, 262, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetTalentTreeNodesAsync_Gets_TalentTreeNodes()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/talent-tree/786?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentTreeNodesResponse);

        RequestResult<TalentTreeNodes> result = await warcraftClient.GetTalentTreeNodesAsync(786, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetTalentsIndexAsync_Gets_TalentsIndex()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/talent/index?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentsIndexResponse);

        RequestResult<TalentsIndex> result = await warcraftClient.GetTalentsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetTalentAsync_Gets_Talent()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/talent/117163?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentResponse);

        RequestResult<Talent> result = await warcraftClient.GetTalentAsync(117163, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpTalentsIndexAsync_Gets_PvpTalentsIndex()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-talent/index?namespace=static-us&locale=en_US",
            responseContent: Resources.PvpTalentsIndexResponse);

        RequestResult<PvpTalentsIndex> result = await warcraftClient.GetPvpTalentsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpTalentAsync_Gets_PvpTalent()
    {
        ITalentApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-talent/11?namespace=static-us&locale=en_US",
            responseContent: Resources.PvpTalentResponse);

        RequestResult<PvpTalent> result = await warcraftClient.GetPvpTalentAsync(11, "static-us");
        Assert.NotNull(result.Value);
    }
}
