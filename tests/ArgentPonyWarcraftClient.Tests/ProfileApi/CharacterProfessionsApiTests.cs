using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterProfessionsApiTests
    {
        [Fact]
        public async void GetCharacterProfessionsSummaryAsync_Gets_CharacterProfessionsSummary()
        {
            ICharacterProfessionsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/professions?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterProfessionsSummaryResponse);

            RequestResult<CharacterProfessionsSummary> result = await warcraftClient.GetCharacterProfessionsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
