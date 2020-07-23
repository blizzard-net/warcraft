using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterReputationsApiTests
    {
        [ResilientFact]
        public async void GetCharacterReputationsSummaryAsync_Gets_CharacterReputationsSummary()
        {
            ICharacterReputationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterReputationsSummary> result = await warcraftClient.GetCharacterReputationsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
