using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class AccountProfileApiTests
{
    [Fact]
    public async Task GetAccountProfileSummaryAsync_Gets_AccountProfileSummary()
    {
        IAccountProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/user/wow?namespace=profile-us&locale=en_US",
            responseContent: Resources.AccountProfileSummaryResponse);

        RequestResult<AccountProfileSummary> result = await warcraftClient.GetAccountProfileSummaryAsync("ACCESS-TOKEN-GOES-HERE", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetProtectedCharacterProfileSummaryAsync_Gets_ProtectedCharacterProfileSummary()
    {
        IAccountProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/user/wow/protected-character/1262-107811065?namespace=profile-us&locale=en_US",
            responseContent: Resources.ProtectedCharacterProfileSummaryResponse);

        RequestResult<ProtectedCharacterProfileSummary> result = await warcraftClient.GetProtectedCharacterProfileSummaryAsync(1262, 107811065, "ACCESS-TOKEN-GOES-HERE", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAccountCollectionsIndexAsync_Gets_AccountCollectionsIndex()
    {
        IAccountProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/user/wow/collections?namespace=profile-us&locale=en_US",
            responseContent: Resources.AccountCollectionsIndexResponse);

        RequestResult<AccountCollectionsIndex> result = await warcraftClient.GetAccountCollectionsIndexAsync("ACCESS-TOKEN-GOES-HERE", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAccountMountsCollectionSummaryAsync_Gets_AccountMountsCollectionSummary()
    {
        IAccountProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/user/wow/collections/mounts?namespace=profile-us&locale=en_US",
            responseContent: Resources.AccountMountsCollectionSummaryResponse);

        RequestResult<AccountMountsCollectionSummary> result = await warcraftClient.GetAccountMountsCollectionSummaryAsync("ACCESS-TOKEN-GOES-HERE", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAccountPetsCollectionSummaryAsync_Gets_AccountPetsCollectionSummary()
    {
        IAccountProfileApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/profile/user/wow/collections/pets?namespace=profile-us&locale=en_US",
            responseContent: Resources.AccountPetsCollectionSummaryResponse);

        RequestResult<AccountPetsCollectionSummary> result = await warcraftClient.GetAccountPetsCollectionSummaryAsync("ACCESS-TOKEN-GOES-HERE", "profile-us");
        Assert.NotNull(result.Value);
    }
}
