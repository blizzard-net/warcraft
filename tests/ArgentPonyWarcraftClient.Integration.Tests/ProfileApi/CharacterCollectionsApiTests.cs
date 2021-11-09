using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi;

public class CharacterCollectionsApiTests
{
    [ResilientFact]
    public async Task GetCharacterCollectionsIndexAsync_Gets_CharacterCollections()
    {
        ICharacterCollectionsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterCollectionsIndex> result = await warcraftClient.GetCharacterCollectionsIndexAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterMountsCollectionSummaryAsync_Gets_CharacterMountsSummary()
    {
        ICharacterCollectionsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterMountsCollectionSummary> result = await warcraftClient.GetCharacterMountsCollectionSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }

    [ResilientFact]
    public async Task GetCharacterPetsCollectionSummaryAsync_Gets_CharacterPetsSummary()
    {
        ICharacterCollectionsApi warcraftClient = ClientFactory.BuildClient();
        RequestResult<CharacterPetsCollectionSummary> result = await warcraftClient.GetCharacterPetsCollectionSummaryAsync("norgannon", "drinian", "profile-us");
        Assert.NotNull(result.Value);
    }
}
