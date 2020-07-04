using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterEquipmentApiTests
    {
        [Fact]
        public async void GetCharacterEquipmentSummaryAsync_Gets_CharacterEquipmentSummary()
        {
            ICharacterEquipmentApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/equipment?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterEquipmentSummaryResponse);

            RequestResult<CharacterEquipmentSummary> result = await warcraftClient.GetCharacterEquipmentSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
