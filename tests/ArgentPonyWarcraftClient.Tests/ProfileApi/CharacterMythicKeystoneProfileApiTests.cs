using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class CharacterMythicKeystoneProfileApiTests
    {
        [Fact]
        public async void GetCharacterMythicKeystoneProfileIndexAsync_Gets_CharacterMythicKeystoneProfileIndex()
        {
            ICharacterMythicKeystoneProfileApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/zuljin/volladin/mythic-keystone-profile?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterMythicKeystoneProfileIndexResponse);

            RequestResult<CharacterMythicKeystoneProfileIndex> result = await warcraftClient.GetCharacterMythicKeystoneProfileIndexAsync("zuljin", "volladin", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterMythicKeystoneSeasonDetailsAsync_Gets_CharacterMythicKeystoneSeasonDetails()
        {
            ICharacterMythicKeystoneProfileApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/zuljin/volladin/mythic-keystone-profile/season/1?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterMythicKeystoneSeasonDetailsResponse);

            RequestResult<CharacterMythicKeystoneSeasonDetails> result = await warcraftClient.GetCharacterMythicKeystoneSeasonDetailsAsync("zuljin", "volladin", 1, "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
