using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterHunterPetsApiTests
    {
        [Fact]
        public async void GetCharacterHunterPetsSummaryAsync_Gets_CharacterHunterPetsSummary()
        {
            ICharacterHunterPetsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/anradin/hunter-pets?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterHunterPetsSummaryResponse);

            RequestResult<CharacterHunterPetsSummary> result = await warcraftClient.GetCharacterHunterPetsSummaryAsync("norgannon", "anradin", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
