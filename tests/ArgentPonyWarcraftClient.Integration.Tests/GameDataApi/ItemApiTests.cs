using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ItemApiTests
    {
        [ResilientFact]
        public async void GetItemClassesIndexAsync_Gets_ItemClassesIndex()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemClassAsync_Gets_ItemClass()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemSetsIndexAsync_Gets_ItemSetsIndex()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemSetsIndex> result = await warcraftClient.GetItemSetsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemSetAsync_Gets_ItemSet()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemSet> result = await warcraftClient.GetItemSetAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemSubclassAsync_Gets_ItemSubclass()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemAsync_Gets_Item()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetItemMediaAsync_Gets_Item()
        {
            IItemApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
