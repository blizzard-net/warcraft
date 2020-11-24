using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterSpecializationsApiTests
    {
        [Fact]
        public async Task GetCharacterSpecializationsSummaryAsync_Gets_CharacterSpecializationsSummary()
        {
            ICharacterSpecializationsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/specializations?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterSpecializationsSummaryResponse);

            RequestResult<CharacterSpecializationsSummary> result = await warcraftClient.GetCharacterSpecializationsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
