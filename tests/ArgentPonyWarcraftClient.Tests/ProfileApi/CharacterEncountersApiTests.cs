using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterEncountersApiTests
    {
        [Fact]
        public async void GetCharacterEncountersSummaryAsync_Gets_CharacterEncountersSummary()
        {
            ICharacterEncountersApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/encounters?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterEncountersSummaryResponse);

            RequestResult<CharacterEncountersSummary> result = await warcraftClient.GetCharacterEncountersSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterDungeonsAsync_Gets_CharacterDungeons()
        {
            ICharacterEncountersApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/encounters/dungeons?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterDungeonsResponse);

            RequestResult<CharacterDungeons> result = await warcraftClient.GetCharacterDungeonsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterRaidsAsync_Gets_CharacterRaids()
        {
            ICharacterEncountersApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/encounters/raids?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterRaidsResponse);

            RequestResult<CharacterRaids> result = await warcraftClient.GetCharacterRaidsAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
