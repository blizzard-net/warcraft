using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterProfileApiTests
    {
        [ResilientFact]
        public async void GetCharacterProfileSummaryAsync_Gets_CharacterProfileSummary()
        {
            ICharacterProfileApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterProfileSummary> result = await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCharacterStatusAsync_Gets_CharacterStatus()
        {
            ICharacterProfileApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterStatus> result = await warcraftClient.GetCharacterStatusAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
