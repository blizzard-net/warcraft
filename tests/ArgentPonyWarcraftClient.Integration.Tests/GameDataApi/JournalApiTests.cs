using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class JournalApiTests
{
    [ResilientFact]
    public async Task GetJournalExpansionsIndexAsync_Gets_JournalExpansions()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<JournalExpansionsIndex> result = await warcraftClient.GetJournalExpansionsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-expansion/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalExpansionAsync_Gets_JournalExpansion()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<JournalExpansion> result = await warcraftClient.GetJournalExpansionAsync(68, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-expansion/68?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalEncountersIndexAsync_Gets_JournalEncounters()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<JournalEncountersIndex> result = await warcraftClient.GetJournalEncountersIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-encounter/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalEncounterAsync_Gets_Encounter()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Encounter> result = await warcraftClient.GetJournalEncounterAsync(89, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-encounter/89?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalInstancesIndexAsync_Gets_JournalInstances()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<JournalInstancesIndex> result = await warcraftClient.GetJournalInstancesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-instance/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalInstanceAsync_Gets_Instance()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Instance> result = await warcraftClient.GetJournalInstanceAsync(63, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/journal-instance/63?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetJournalInstanceMediaAsync_Gets_InstanceMedia()
    {
        IJournalApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<JournalInstanceMedia> result = await warcraftClient.GetJournalInstanceMediaAsync(63, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/journal-instance/63?namespace=static-us&locale=en_US");
    }
}
