using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi
{
    public class CharacterCollectionsApiTests
    {
        [Fact]
        public async Task GetCharacterCollectionsIndexAsync_Gets_CharacterCollections()
        {
            ICharacterCollectionsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/collections?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterCollectionsIndexResponse);

            RequestResult<CharacterCollectionsIndex> result = await warcraftClient.GetCharacterCollectionsIndexAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetCharacterMountsCollectionSummaryAsync_Gets_CharacterMountsSummary()
        {
            ICharacterCollectionsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/collections/mounts?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterMountsCollectionSummaryResponse);

            RequestResult<CharacterMountsCollectionSummary> result = await warcraftClient.GetCharacterMountsCollectionSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task GetCharacterPetsCollectionSummaryAsync_Gets_CharacterPetsSummary()
        {
            ICharacterCollectionsApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/collections/pets?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterPetsCollectionSummaryResponse);

            RequestResult<CharacterPetsCollectionSummary> result = await warcraftClient.GetCharacterPetsCollectionSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
