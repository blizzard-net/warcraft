using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicKeystoneAffixApiTests
    {
        [ResilientFact]
        public async Task GetMythicKeystoneLeaderboardsIndexAsync_Gets_MythicKeystoneLeaderboardsIndex()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<MythicKeystoneAffixesIndex> result = await warcraftClient.GetMythicKeystoneAffixesIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/keystone-affix/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetMythicKeystoneAffixAsync_Gets_MythicKeystoneAffix()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<MythicKeystoneAffix> result = await warcraftClient.GetMythicKeystoneAffixAsync(1, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/keystone-affix/1?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetMythicKeystoneAffixMediaAsync_Gets_MythicKeystoneAffixMedia()
        {
            IMythicKeystoneAffixApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<MythicKeystoneAffixMedia> result = await warcraftClient.GetMythicKeystoneAffixMediaAsync(1, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/keystone-affix/1?namespace=static-us&locale=en_US");
        }
    }
}
