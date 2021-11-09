using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class ItemApiTests
{
    [Fact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/index?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemClassesIndexResponse);

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemClassAsync_Gets_ItemClass()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/0?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemClassResponse);

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSetsIndexAsync_Gets_ItemSetsIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-set/index?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemSetsIndexResponse);

        RequestResult<ItemSetsIndex> result = await warcraftClient.GetItemSetsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSetAsync_Gets_ItemSet()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-set/1?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemSetResponse);

        RequestResult<ItemSet> result = await warcraftClient.GetItemSetAsync(1, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemSubclassResponse);

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemResponse);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemMediaAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/item/19019?namespace=static-us&locale=en_US",
            responseContent: Resources.ItemMediaResponse);

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-us");
        Assert.NotNull(result.Value);
    }
}
