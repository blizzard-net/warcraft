using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class ItemApiTests
{
    [ResilientFact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemClassAsync_Gets_ItemClass()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/0?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemSetsIndexAsync_Gets_ItemSetsIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSetsIndex> result = await warcraftClient.GetItemSetsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-set/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemSetAsync_Gets_ItemSet()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSet> result = await warcraftClient.GetItemSetAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-set/1?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item/19019?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemMediaAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/item/19019?namespace=static-us&locale=en_US");
    }
}
