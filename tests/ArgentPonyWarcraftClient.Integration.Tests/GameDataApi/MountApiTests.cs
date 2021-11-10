namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class MountApiTests
{
    [ResilientFact]
    public async Task GetMountsIndexAsync_Gets_MountsIndex()
    {
        IMountApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<MountsIndex> result = await warcraftClient.GetMountsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mount/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetMountAsync_Gets_Mount()
    {
        IMountApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Mount> result = await warcraftClient.GetMountAsync(6, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/mount/6?namespace=static-us&locale=en_US");
    }
}
