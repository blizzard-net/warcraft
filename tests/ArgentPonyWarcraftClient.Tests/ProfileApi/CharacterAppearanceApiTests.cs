using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterAppearanceApiTests
    {
        [Fact]
        public async Task GetCharacterAppearanceSummaryAsync_Gets_CharacterAppearanceSummary()
        {
            ICharacterAppearanceApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/appearance?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterAppearanceSummaryResponse);

            RequestResult<CharacterAppearanceSummary> result = await warcraftClient.GetCharacterAppearanceSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
