using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterTitlesApiTests
    {
        [Fact]
        public async Task GetCharacterTitlesSummaryAsync_Gets_CharacterTitlesSummary()
        {
            ICharacterTitlesApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/titles?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterTitlesSummaryResponse);

            RequestResult<CharacterTitlesSummary> result = await warcraftClient.GetCharacterTitlesSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
