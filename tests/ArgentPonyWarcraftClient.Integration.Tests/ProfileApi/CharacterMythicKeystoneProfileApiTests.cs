using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class CharacterMythicKeystoneProfileApiTests
    {
        [ResilientFact]
        public async void GetCharacterMythicKeystoneProfileIndexAsync_Gets_CharacterMythicKeystoneProfileIndex()
        {
            ICharacterMythicKeystoneProfileApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterMythicKeystoneProfileIndex> result = await warcraftClient.GetCharacterMythicKeystoneProfileIndexAsync("zuljin", "volladin", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCharacterMythicKeystoneSeasonDetailsAsync_Gets_CharacterMythicKeystoneSeasonDetails()
        {
            ICharacterMythicKeystoneProfileApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CharacterMythicKeystoneSeasonDetails> result = await warcraftClient.GetCharacterMythicKeystoneSeasonDetailsAsync("zuljin", "volladin", 1, "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
