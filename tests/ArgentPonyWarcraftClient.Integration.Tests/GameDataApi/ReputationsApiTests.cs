using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class ReputationFactionApiTests
{
    [ResilientFact]
    public async Task GetReputationFactionsIndexAsync_Gets_ReputationFactionsIndex()
    {
        IReputationsApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ReputationFactionsIndex> result = await warcraftClient.GetReputationFactionsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/reputation-faction/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetReputationFactionAsync_Gets_ReputationFaction()
    {
        IReputationsApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ReputationFaction> result = await warcraftClient.GetReputationFactionAsync(21, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/reputation-faction/21?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetReputationTiersIndexAsync_Gets_ReputationTiersIndex()
    {
        IReputationsApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ReputationTiersIndex> result = await warcraftClient.GetReputationTiersIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/reputation-tiers/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetReputationTiersAsync_Gets_ReputationTiers()
    {
        IReputationsApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ReputationTiers> result = await warcraftClient.GetReputationTiersAsync(2, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/reputation-tiers/2?namespace=static-us&locale=en_US");
    }
}
