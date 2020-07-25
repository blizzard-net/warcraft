using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterEquipmentApiTests
    {
        [ResilientFact]
        public async void GetCharacterEquipmentSummaryAsync_Gets_CharacterEquipmentSummary()
        {
            ICharacterEquipmentApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterEquipmentSummary> result = await warcraftClient.GetCharacterEquipmentSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
