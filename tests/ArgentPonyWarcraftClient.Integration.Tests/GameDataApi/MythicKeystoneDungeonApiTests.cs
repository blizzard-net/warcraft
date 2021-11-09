using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class MythicKeystoneDungeonApiTests
{
    [ResilientFact]
    public async Task GetMythicKeystoneDungeonsIndexAsync_Gets_MythicKeystoneDungeonsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystoneDungeonsIndex> result = await warcraftClient.GetMythicKeystoneDungeonsIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/dungeon/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystoneDungeonAsync_Gets_MythicKeystoneDungeon()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystoneDungeon> result = await warcraftClient.GetMythicKeystoneDungeonAsync(375, "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/dungeon/375?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystoneIndexAsync_Gets_MythicKeystoneIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystoneIndex> result = await warcraftClient.GetMythicKeystoneIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystonePeriodsIndexAsync_Gets_MythicKeystonePeriodsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystonePeriodsIndex> result = await warcraftClient.GetMythicKeystonePeriodsIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/period/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystonePeriodAsync_Gets_MythicKeystonePeriod()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystonePeriod> result = await warcraftClient.GetMythicKeystonePeriodAsync(641, "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/period/641?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystoneSeasonsIndexAsync_Gets_MythicKeystoneSeasonsIndex()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystoneSeasonsIndex> result = await warcraftClient.GetMythicKeystoneSeasonsIndexAsync("dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/season/index?namespace=dynamic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMythicKeystoneSeasonAsync_Gets_MythicKeystoneSeason()
    {
        IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MythicKeystoneSeason> result = await warcraftClient.GetMythicKeystoneSeasonAsync(1, "dynamic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mythic-keystone/season/1?namespace=dynamic-us&locale=en_US");
    }
}
