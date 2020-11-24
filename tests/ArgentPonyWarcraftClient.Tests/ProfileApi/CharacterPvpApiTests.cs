using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterPvpApiTests
    {
        [Fact]
        public async Task GetCharacterPvpBracketStatisticsAsync_Gets_PvpBracketStatistics()
        {
            ICharacterPvpApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/malganis/zenli/pvp-bracket/3v3?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterPvpBracketStatisticsResponse);

            RequestResult<CharacterPvpBracketStatistics> result = await warcraftClient.GetCharacterPvpBracketStatisticsAsync("malganis", "zenli", "3v3", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetCharacterPvpSummaryAsync_Gets_CharacterPvpSummary()
        {
            ICharacterPvpApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/malganis/zenli/pvp-summary?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterPvpSummaryResponse);

            RequestResult<CharacterPvpSummary> result = await warcraftClient.GetCharacterPvpSummaryAsync("malganis", "zenli", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
