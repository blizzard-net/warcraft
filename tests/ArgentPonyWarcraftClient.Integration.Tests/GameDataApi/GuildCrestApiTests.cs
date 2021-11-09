using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class GuildCrestApiTests
{
    [ResilientFact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/guild-crest/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/guild-crest/border/0?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/guild-crest/emblem/0?namespace=static-us&locale=en_US");
    }
}
