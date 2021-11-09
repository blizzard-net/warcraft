using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class JournalApiTests
{
    [Fact]
    public async Task GetJournalExpansionsIndexAsync_Gets_JournalExpansions()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-expansion/index?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalExpansionsIndexResponse);

        RequestResult<JournalExpansionsIndex> result = await warcraftClient.GetJournalExpansionsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalExpansionAsync_Gets_JournalExpansion()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-expansion/68?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalExpansionResponse);

        RequestResult<JournalExpansion> result = await warcraftClient.GetJournalExpansionAsync(68, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalEncountersIndexAsync_Gets_JournalEncounters()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-encounter/index?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalEncountersIndexResponse);

        RequestResult<JournalEncountersIndex> result = await warcraftClient.GetJournalEncountersIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalEncounterAsync_Gets_Encounter()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-encounter/89?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalEncounterResponse);

        RequestResult<Encounter> result = await warcraftClient.GetJournalEncounterAsync(89, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalInstancesIndexAsync_Gets_JournalInstances()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-instance/index?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalInstancesIndexResponse);

        RequestResult<JournalInstancesIndex> result = await warcraftClient.GetJournalInstancesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalInstanceAsync_Gets_Instance()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-instance/63?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalInstanceResponse);

        RequestResult<Instance> result = await warcraftClient.GetJournalInstanceAsync(63, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetJournalInstanceMediaAsync_Gets_InstanceMedia()
    {
        IJournalApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/journal-instance/63?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalInstanceMediaResponse);

        RequestResult<JournalInstanceMedia> result = await warcraftClient.GetJournalInstanceMediaAsync(63, "static-us");
        Assert.NotNull(result.Value);
    }
}
