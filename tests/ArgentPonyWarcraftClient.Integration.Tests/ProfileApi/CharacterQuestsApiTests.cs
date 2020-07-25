using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterQuestsApiTests
    {
        [ResilientFact]
        public async void GetCharacterQuestsAsync_Gets_CharacterQuests()
        {
            ICharacterQuestsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterQuests> result = await warcraftClient.GetCharacterQuestsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCharacterCompletedQuestsAsync_Gets_CharacterCompletedQuests()
        {
            ICharacterQuestsApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterCompletedQuests> result = await warcraftClient.GetCharacterCompletedQuestsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
