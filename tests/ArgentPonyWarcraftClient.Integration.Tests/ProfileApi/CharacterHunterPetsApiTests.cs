using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterHunterPetsApiTests
    {
        [ResilientFact]
        public async void GetCharacterHunterPetsSummaryAsync_Gets_CharacterHunterPetsSummary()
        {
            ICharacterHunterPetsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterHunterPetsSummary> result = await warcraftClient.GetCharacterHunterPetsSummaryAsync("norgannon", "anradin", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
