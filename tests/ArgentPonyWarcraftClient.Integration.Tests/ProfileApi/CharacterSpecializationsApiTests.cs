using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterSpecializationsApiTests
    {
        [ResilientFact]
        public async Task GetCharacterSpecializationsSummaryAsync_Gets_CharacterSpecializationsSummary()
        {
            ICharacterSpecializationsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterSpecializationsSummary> result = await warcraftClient.GetCharacterSpecializationsSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
