using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class CreatureApiTests
{
    [Fact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/creature-family/index?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureFamiliesIndexResponse);

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/creature-family/1?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureFamilyResponse);

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/creature-type/index?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureTypesIndexResponse);

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/creature-type/1?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureTypeResponse);

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureAsync_Gets_Creature()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/creature/42722?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureResponse);

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(42722, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/creature-display/30221?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureDisplayMediaResponse);

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30221, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/creature-family/1?namespace=static-us&locale=en_US",
            responseContent: Resources.CreatureFamilyMediaResponse);

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }
}
