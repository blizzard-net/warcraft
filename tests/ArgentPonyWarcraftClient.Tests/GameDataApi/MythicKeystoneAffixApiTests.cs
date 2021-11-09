using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class MythicKeystoneAffixApiTests
{
    [Fact]
    public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
    {
        IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/keystone-affix/index?namespace=static-us&locale=en_US",
            responseContent: Resources.MythicKeystoneAffixesIndexResponse);

        RequestResult<MythicKeystoneAffixesIndex> result = await warcraftClient.GetMythicKeystoneAffixesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneAffixAsync_Gets_MythicKeystoneAffix()
    {
        IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/keystone-affix/1?namespace=static-us&locale=en_US",
            responseContent: Resources.MythicKeystoneAffixResponse);

        RequestResult<MythicKeystoneAffix> result = await warcraftClient.GetMythicKeystoneAffixAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMythicKeystoneAffixMediaAsync_Gets_MythicKeystoneAffixMedia()
    {
        IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/keystone-affix/1?namespace=static-us&locale=en_US",
            responseContent: Resources.MythicKeystoneAffixMediaResponse);

        RequestResult<MythicKeystoneAffixMedia> result = await warcraftClient.GetMythicKeystoneAffixMediaAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }
}
