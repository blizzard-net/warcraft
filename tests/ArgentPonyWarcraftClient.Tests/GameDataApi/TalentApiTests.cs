using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class TalentApiTests
{
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
            requestUri: "https://us.api.blizzard.com/data/wow/talent/23106?namespace=static-us&locale=en_US",
            responseContent: Resources.TalentResponse);

        RequestResult<Talent> result = await warcraftClient.GetTalentAsync(23106, "static-us");
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
