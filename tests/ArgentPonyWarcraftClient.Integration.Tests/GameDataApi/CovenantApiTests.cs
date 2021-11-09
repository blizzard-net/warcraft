using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class CovenantApiTests
{
    [ResilientFact]
    public async Task When_Getting_A_Conduit_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<Conduit> result = await client.GetConduitAsync(17, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/conduit/17?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_A_Covenant_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<Covenant> result = await client.GetCovenantAsync(3, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/3?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_A_Soulbind_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<Soulbind> result = await client.GetSoulbindAsync(9, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/soulbind/9?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_Conduits_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<ConduitsIndex> result = await client.GetConduitsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/conduit/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_Covenant_Media_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<CovenantMedia> result = await client.GetCovenantMediaAsync(3, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/covenant/3?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_Covenants_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<CovenantsIndex> result = await client.GetCovenantsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task When_Getting_Soulbinds_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
    {
        ICovenantApi client = ClientFactory.BuildClient();

        RequestResult<SoulbindsIndex> result = await client.GetSoulbindsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/covenant/soulbind/index?namespace=static-us&locale=en_US");
    }
}
